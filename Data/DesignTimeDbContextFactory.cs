using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Npgsql;
using System;

namespace MultiStepFormApp.Data
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var databaseUrl = Environment.GetEnvironmentVariable("DATABASE_URL");

            if (string.IsNullOrEmpty(databaseUrl))
                throw new Exception("DATABASE_URL not found. Set environment variable first.");

            var uri = new Uri(databaseUrl);
            var userInfo = uri.UserInfo.Split(':');

            var builder = new NpgsqlConnectionStringBuilder
            {
                Host = uri.Host,
                Port = uri.Port == -1 ? 5432 : uri.Port,
                Database = uri.AbsolutePath.Trim('/'),
                Username = userInfo[0],
                Password = userInfo.Length > 1 ? userInfo[1] : "",
                SslMode = SslMode.Require,
                TrustServerCertificate = true
            };

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseNpgsql(builder.ConnectionString);

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
