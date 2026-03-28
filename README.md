<div align="center">

# 🪐 NOVA ADMIN

### Multi-Step Application Form & Admin Management System

[![.NET](https://img.shields.io/badge/.NET-8.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![ASP.NET Core](https://img.shields.io/badge/ASP.NET_Core-MVC-5C2D91?style=for-the-badge&logo=dotnet)](https://dotnet.microsoft.com/apps/aspnet)
[![PostgreSQL](https://img.shields.io/badge/PostgreSQL-336791?style=for-the-badge&logo=postgresql&logoColor=white)](https://www.postgresql.org/)
[![EF Core](https://img.shields.io/badge/Entity_Framework-Core_8.0-6DB33F?style=for-the-badge)](https://docs.microsoft.com/en-us/ef/core/)
[![Docker](https://img.shields.io/badge/Docker-2496ED?style=for-the-badge&logo=docker&logoColor=white)](https://www.docker.com/)
[![Render](https://img.shields.io/badge/Hosted_On-Render-000000?style=for-the-badge)](https://render.com/)

<br/>

**🌐 [Live Demo](https://nova-admin-torz.onrender.com) &nbsp;|&nbsp; 🎬 [Watch on YouTube](https://youtu.be/NQCug-ooOQk) &nbsp;|&nbsp; ⭐ [Star this Repo](https://github.com/DecodeX7/Nova-Admin) &nbsp;|&nbsp; 🐛 [Report a Bug](https://github.com/DecodeX7/Nova-Admin/issues)**

<br/>

[![Watch Demo](https://img.shields.io/badge/▶_Watch_Full_Demo-FF0000?style=for-the-badge&logo=youtube&logoColor=white)](https://youtu.be/NQCug-ooOQk)
[![Live Site](https://img.shields.io/badge/🌐_Visit_Live_Site-00C7B7?style=for-the-badge)](https://nova-admin-torz.onrender.com)

<br/>

![HTML](https://img.shields.io/badge/HTML-59.5%25-E34F26?style=flat-square&logo=html5&logoColor=white)
![C#](https://img.shields.io/badge/C%23-36.8%25-239120?style=flat-square&logo=csharp&logoColor=white)
![CSS](https://img.shields.io/badge/CSS-2.9%25-1572B6?style=flat-square&logo=css3&logoColor=white)

</div>

---

## 🌟 What is Nova Admin?

**Nova Admin** is a production-ready, fully deployed web application that simulates a real-world structured application portal — think College Admissions, Government Registration, Job Application Systems, or Scholarship Portals.

Applicants navigate a clean **multi-step guided form**, review their data on a preview page, and submit — all stored persistently in **PostgreSQL**. Admins get a powerful dashboard to **view, edit, and delete** every submission with dynamic education record rendering.

Built on **ASP.NET Core MVC (.NET 8)**, containerized with **Docker**, and live on **Render** with an external PostgreSQL database — this is a full production deployment, not just a localhost demo.

---

## 🔗 Live Access

| Resource | Link |
|---|---|
| 🌐 **Live Application** | [https://nova-admin-torz.onrender.com](https://nova-admin-torz.onrender.com) |
| 🎬 **YouTube Demo** | [https://youtu.be/NQCug-ooOQk](https://youtu.be/NQCug-ooOQk) |
| 💻 **GitHub Repo** | [https://github.com/DecodeX7/Nova-Admin](https://github.com/DecodeX7/Nova-Admin) |

---

## ✨ Features

### 👤 Applicant Side

- 📝 **Multi-Step Guided Form** — Structured step-by-step data entry (Personal → Qualification → Address)
- 💾 **Session-Based Progress Saving** — Never lose your data mid-form, progress is preserved
- 👁️ **Preview Before Submit** — Full summary review page before final confirmation
- ✏️ **Edit Before Submission** — Go back and modify any step before committing
- 🛡️ **Validation-Protected Form** — Client & server-side validation at every step
- ✅ **Smooth Confirmation Flow** — Success state with clear submission feedback

### 🛠️ Admin Panel

- 📋 **View All Applicants** — Paginated table of every submission at a glance
- 🔍 **Detailed Profile View** — Expand any applicant's full record
- ✏️ **Edit Any Record** — Update applicant data directly from the admin panel
- 🗑️ **Delete Records** — Remove entries with confirmation guard
- 🎓 **Dynamic Education Rendering** — JSON-stored education data elegantly rendered as a UI table

### ⚙️ Backend & Infrastructure

- ASP.NET Core MVC on .NET 8 — fast, modern, production-grade
- Entity Framework Core with PostgreSQL via `Npgsql`
- Automatic database migrations on deploy — zero manual setup
- Session management with configurable idle timeout
- Environment variable-based configuration for secure secrets
- Production error handling with graceful fallback pages

### ☁️ Deployment & DevOps

- 🐳 **Dockerized** — Full `Dockerfile` included for container-based deployment
- 🚀 **Hosted on Render** — Live with external PostgreSQL database
- 🔒 **SSL-secured** database connection
- ⚙️ **`appsettings.Production.json`** for clean environment separation

---

## 🗺️ Application Flow

```
┌─────────────┐    ┌───────────────┐    ┌──────────────┐    ┌─────────┐    ┌──────────┐    ┌──────────────┐
│  👤 Personal │ →  │ 🎓 Qualification│ → │ 🏠 Address    │ →  │ 👁 Preview│ →  │ ✅ Submit │ →  │ 🗄 PostgreSQL │
│    Details   │    │    Details    │    │   Details    │    │  Page   │    │          │    │  + Admin DB  │
└─────────────┘    └───────────────┘    └──────────────┘    └─────────┘    └──────────┘    └──────────────┘
                                                                                                    ↓
                                                                                          ┌──────────────────┐
                                                                                          │  🛠 Admin Panel   │
                                                                                          │  View/Edit/Delete │
                                                                                          └──────────────────┘
```

---

## 🛠️ Tech Stack

| Layer | Technology | Version |
|---|---|---|
| **Framework** | ASP.NET Core MVC | .NET 8.0 |
| **Language** | C# | Latest |
| **Frontend** | Razor Views + Bootstrap | — |
| **Styling** | CSS3 + Bootstrap | — |
| **ORM** | Entity Framework Core | 8.0.0 |
| **Database** | PostgreSQL (via Npgsql) | 8.0.0 |
| **Session** | ASP.NET Core Session | 2.3.9 |
| **Serialization** | System.Text.Json | Built-in |
| **Containerization** | Docker | — |
| **Hosting** | Render | — |

---

## 📦 NuGet Packages

| Package | Version | Purpose |
|---|---|---|
| `Npgsql.EntityFrameworkCore.PostgreSQL` | 8.0.0 | PostgreSQL ORM provider |
| `Microsoft.EntityFrameworkCore` | 8.0.0 | Core ORM engine |
| `Microsoft.EntityFrameworkCore.Design` | 8.0.0 | Design-time tooling |
| `Microsoft.EntityFrameworkCore.SqlServer` | 8.0.0 | SQL Server compatibility |
| `Microsoft.EntityFrameworkCore.Tools` | 8.0.0 | CLI migration tooling |
| `Microsoft.AspNetCore.Session` | 2.3.9 | Server-side session state |
| `Microsoft.VisualStudio.Web.CodeGeneration.Design` | 8.0.0 | Scaffolding support |

---

## 📁 Project Structure

```
Nova-Admin/
│
├── Controllers/
│   ├── FormController.cs         # Handles all form steps & session logic
│   └── AdminController.cs        # Admin CRUD operations
│
├── Models/
│   ├── PersonalDetails.cs        # Step 1 model
│   ├── QualificationDetails.cs   # Step 2 model (education stored as JSON)
│   ├── AddressDetails.cs         # Step 3 model
│   └── FormEntry.cs              # Unified DB entity
│
├── Data/
│   └── ApplicationDbContext.cs   # EF Core database context
│
├── Migrations/                   # Auto-generated EF Core migrations
│
├── Views/
│   ├── Form/                     # Step views (Personal, Qualification, Address, Preview)
│   └── Admin/                    # Dashboard, Detail, Edit views
│
├── wwwroot/                      # Static assets (CSS, JS, images)
│   └── css/
│       └── site.css
│
├── Properties/
│   └── launchSettings.json
│
├── Dockerfile                    # Container build instructions
├── Program.cs                    # App entry point & DI setup
├── appsettings.json              # Base configuration
├── appsettings.Production.json   # Production environment config
└── MultiStepFormApp.csproj       # Project dependencies
```

---

## 🗄️ Database Design

The main table `FormEntries` stores all applicant submissions in a single, flat structure.

```
FormEntries
├── Id                  (Primary Key)
├── FullName
├── Email
├── Phone
├── DateOfBirth
├── Gender
├── Address
├── City
├── State
├── PinCode
├── EducationJson       ← Dynamic education records stored as JSON array
└── SubmittedAt
```

> 💡 **Why JSON for Education?** — Education records are dynamic in count (applicants may have multiple degrees, certifications). Storing them as a JSON column avoids the complexity of a separate table while keeping the schema clean and queryable.

---

## 🚀 Getting Started (Local)

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8)
- [PostgreSQL](https://www.postgresql.org/download/) installed locally
- [Docker](https://www.docker.com/) *(optional, for container run)*

### Option A — Run Directly with .NET

**1. Clone the repository**
```bash
git clone https://github.com/DecodeX7/Nova-Admin.git
cd Nova-Admin
```

**2. Configure your database connection**

Edit `appsettings.json`:
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Host=localhost;Database=NovaAdminDB;Username=postgres;Password=yourpassword"
  }
}
```

**3. Apply database migrations**
```bash
dotnet ef database update
```

**4. Run the application**
```bash
dotnet run
```

**5. Open in browser**
```
https://localhost:5001
```

---

### Option B — Run with Docker 🐳

**1. Build the Docker image**
```bash
docker build -t nova-admin .
```

**2. Run the container**
```bash
docker run -p 8080:80 \
  -e ConnectionStrings__DefaultConnection="Host=host.docker.internal;Database=NovaAdminDB;Username=postgres;Password=yourpassword" \
  nova-admin
```

**3. Open in browser**
```
http://localhost:8080
```

---

## ☁️ Deployment (Render)

Nova Admin is deployed on **Render** with an external PostgreSQL database. Here's the setup:

1. Push your code to GitHub
2. Create a new **Web Service** on [Render](https://render.com)
3. Set **Build Command**: `dotnet publish -c Release -o out`
4. Set **Start Command**: `dotnet out/MultiStepFormApp.dll`
5. Add environment variable:
   ```
   ConnectionStrings__DefaultConnection = <your-render-postgres-url>
   ```
6. Render auto-deploys on every push to `master` ✅

---

## 💼 Real-World Use Cases

Nova Admin's architecture is applicable to a wide range of real-world portals:

| Use Case | Description |
|---|---|
| 🎓 **College Admission Portal** | Collect student applications with education history |
| 💼 **Job Application System** | Gather applicant details with qualification steps |
| 🏛️ **Government Registration** | Multi-step citizen registration forms |
| 🏅 **Scholarship Application** | Structured eligibility and document collection |
| 📊 **Survey & Data Collection** | Any structured multi-step data gathering workflow |

---

## 🤝 Contributing

Contributions, ideas, and improvements are welcome!

1. **Fork** the repository
2. **Create** your feature branch (`git checkout -b feature/AmazingFeature`)
3. **Commit** your changes (`git commit -m 'Add AmazingFeature'`)
4. **Push** to the branch (`git push origin feature/AmazingFeature`)
5. **Open** a Pull Request

---

## 📄 License

This project is open-source and available under the **MIT License**.

---

## 👨‍💻 Author

<div align="center">

**DecodeX7**

*B.Tech CSE (AI) · Full Stack Developer*

[![GitHub](https://img.shields.io/badge/GitHub-DecodeX7-181717?style=for-the-badge&logo=github&logoColor=white)](https://github.com/DecodeX7)

<br/>

*If Nova Admin helped or inspired you, drop a ⭐ — it genuinely means a lot!*

</div>

---

<div align="center">

Built with 💜 using ASP.NET Core · PostgreSQL · Docker · Render

</div>
