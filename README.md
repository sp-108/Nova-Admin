⭐ Nova-Admin — Multi Step Application Form System

A full-stack ASP.NET Core MVC production application that collects applicant data through a multi-step form and provides a powerful admin dashboard to manage records.

🌐 Live Demo:
👉 https://nova-admin-torz.onrender.com

🧠 Project Overview

Nova-Admin is a production-ready web application built to simulate a real government / college / job application portal.

Users fill a structured multi-step form → Data is validated → Stored in PostgreSQL → Managed via Admin dashboard.

The system focuses on:

Clean UX

Structured data storage

Secure submission

Real-world deployment architecture

✨ Features
👨‍💻 User Side (Applicant)

Multi-step form (Personal → Qualification → Address → Preview)

Session based step navigation

Edit before final submit

Data validation

Preview before submission

Secure form submission

🛠️ Admin Panel

Dashboard with all submissions

Detailed applicant view

Edit records

Delete records

Structured education display (JSON → UI conversion)

Clean card based UI

⚙️ Backend

ASP.NET Core MVC (.NET 8)

Entity Framework Core

PostgreSQL database

Server-side session management

Production error handling

Automatic migrations on deploy

☁️ Deployment (Production Ready)

Hosted on Render

External PostgreSQL Database

Environment variable based configuration

Auto DB migration on startup

Secure SSL DB connection

🧱 Tech Stack
Layer	Technology
Frontend	Razor Views + Bootstrap
Backend	ASP.NET Core MVC (.NET 8)
ORM	Entity Framework Core
Database	PostgreSQL
Hosting	Render
Session	ASP.NET Core Session Middleware
Serialization	System.Text.Json
📂 Project Architecture
Nova-Admin
│
├── Controllers
│   ├── FormController (Multi step logic)
│   ├── AdminController (Dashboard)
│   └── HomeController
│
├── Models
│   ├── PersonalDetails
│   ├── QualificationDetails
│   ├── AddressDetails
│   └── FormEntry (DB Entity)
│
├── Views
│   ├── Form (Steps UI)
│   ├── Admin (Dashboard)
│   └── Shared Layout
│
├── Data
│   └── ApplicationDbContext
│
└── Program.cs

🧩 Database Design

Main Table: FormEntries

Stores:

Personal Information

Address

Contact

Education (stored as JSON → dynamic rendering)

Why JSON?

Because education records are dynamic and variable length — normalized tables would complicate form UX.

🔐 Environment Variables (Production)

Required on Render:

DATABASE_URL=postgresql://user:password@host/dbname
ASPNETCORE_ENVIRONMENT=Production


App automatically converts DATABASE_URL → Npgsql connection string.

🚀 Run Locally
1️⃣ Clone
git clone https://github.com/sp-108/Nova-Admin.git
cd Nova-Admin

2️⃣ Configure Database

Edit appsettings.json

"ConnectionStrings": {
  "DefaultConnection": "Server=.;Database=NovaAdmin;Trusted_Connection=True;TrustServerCertificate=True"
}

3️⃣ Apply Migrations
dotnet ef database update

4️⃣ Run
dotnet run


Open:

https://localhost:5001

🧪 How It Works (Flow)
User fills step → Stored in Session
All steps complete → Preview page
Submit → Combined Model → DB
Admin → Manage entries

📸 Screens

(You can add screenshots later here — GitHub will look premium)

/screenshots/form.png
/screenshots/dashboard.png
/screenshots/details.png

💡 Real World Use Cases

College Admission Portal

Scholarship Application System

Job Application Portal

Survey Data Collection System

Government Registration Forms

🧑‍💻 Author

Saurabh Prajapati
B.Tech CSE (AI)
Full Stack Developer (.NET + ML + Systems)

GitHub: https://github.com/sp-108

🌟 If you like this project

Give it a star ⭐ — it helps a lot!

🔥 Recruiter Note

This project demonstrates:

✔ Backend architecture
✔ Database modeling
✔ Session state management
✔ Production deployment
✔ Debugging real hosting issues
✔ Migration handling
✔ Real-world form workflow
