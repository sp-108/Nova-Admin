using Microsoft.EntityFrameworkCore;
using MultiStepFormApp.Data;
using Npgsql;

var builder = WebApplication.CreateBuilder(args);


// ================= PORT FIX (RENDER) =================
var port = Environment.GetEnvironmentVariable("PORT") ?? "8080";
builder.WebHost.UseUrls($"http://0.0.0.0:{port}");


// ================= DATABASE =================
var databaseUrl = Environment.GetEnvironmentVariable("DATABASE_URL");

if (!string.IsNullOrEmpty(databaseUrl))
{
    try
    {
        var uri = new Uri(databaseUrl);

        var userInfo = uri.UserInfo.Split(':', 2);
        var username = userInfo[0];
        var password = userInfo.Length > 1 ? userInfo[1] : "";

        var db = uri.AbsolutePath.TrimStart('/');

        var connBuilder = new NpgsqlConnectionStringBuilder
        {
            Host = uri.Host,
            Port = uri.Port > 0 ? uri.Port : 5432,
            Database = db,
            Username = username,
            Password = password,

            // ===== REQUIRED FOR RENDER EXTERNAL DB =====
            SslMode = SslMode.Require,
            TrustServerCertificate = true,

            // Prevent random disconnect
            KeepAlive = 30,
            TcpKeepAlive = true,

            // Performance + stability
            Pooling = true,
            MinPoolSize = 0,
            MaxPoolSize = 20,
            Timeout = 15,
            CommandTimeout = 30
        };

        var connectionString = connBuilder.ConnectionString;

        Console.WriteLine("Using PostgreSQL (Render External)");

        builder.Services.AddDbContext<ApplicationDbContext>(options =>
            options.UseNpgsql(connectionString));
    }
    catch (Exception ex)
    {
        Console.WriteLine("DATABASE PARSE ERROR: " + ex.Message);
    }
}
else
{
    // ===== LOCAL DEVELOPMENT =====
    var conn = builder.Configuration.GetConnectionString("DefaultConnection");
    Console.WriteLine("Using Local SQL Server");

    builder.Services.AddDbContext<ApplicationDbContext>(options =>
        options.UseSqlServer(conn));
}



// ================= SERVICES =================
builder.Services.AddControllersWithViews();
builder.Services.AddDistributedMemoryCache();

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});


var app = builder.Build();


// ================= AUTO MIGRATION SAFE =================
using (var scope = app.Services.CreateScope())
{
    try
    {
        var db = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        db.Database.Migrate();
        Console.WriteLine("Database migrated successfully");
    }
    catch (Exception ex)
    {
        Console.WriteLine("Migration skipped: " + ex.Message);
    }
}



// ================= MIDDLEWARE =================
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseStaticFiles();
app.UseRouting();
app.UseSession();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Admin}/{action=Index}/{id?}");

app.Run();
