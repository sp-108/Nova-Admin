🚀 Nova-Admin
✨ Multi-Step Application Form & Admin Management System
<p align="center"> <b>A production-ready ASP.NET Core MVC web application to collect and manage applicant data</b> </p> <p align="center">










</p>
🌐 Live Website

👉 https://nova-admin-torz.onrender.com

📌 About The Project

Nova-Admin is a real-world style application portal.

Users fill a structured multi-step form → preview → submit → stored in PostgreSQL → managed through admin dashboard.

This project focuses on:

✔ Clean UX
✔ Structured Data Storage
✔ Secure Submission Flow
✔ Production Deployment
✔ Debugging real hosting issues

🎯 Core Features
👤 Applicant Side

Multi-step form navigation

Session-based progress tracking

Edit before final submit

Preview full application

Validation protected submission

🛠 Admin Dashboard

View all applicants

Detailed profile page

Edit application

Delete records

Dynamic education rendering

⚙ Backend Capabilities

ASP.NET Core MVC (.NET 8)

Entity Framework Core

PostgreSQL integration

Auto database migration on deploy

Production error handling

☁ Production Deployment

Hosted on Render

External PostgreSQL DB

Environment variable configuration

Secure SSL database connection

🧱 Tech Stack
Layer	Technology
Frontend	Razor + Bootstrap
Backend	ASP.NET Core MVC
Database	PostgreSQL
ORM	Entity Framework Core
Hosting	Render
Session	ASP.NET Session
Serialization	System.Text.Json
🗂 Project Structure
Nova-Admin
│
├── Controllers
│   ├── FormController
│   ├── AdminController
│   └── HomeController
│
├── Models
│   ├── PersonalDetails
│   ├── QualificationDetails
│   ├── AddressDetails
│   └── FormEntry
│
├── Views
│   ├── Form Steps
│   ├── Admin Dashboard
│   └── Shared Layout
│
├── Data
│   └── ApplicationDbContext
│
└── Program.cs

🗄 Database Design

Main Table: FormEntries

Stores:

Personal Info

Contact Info

Address

Education (JSON stored)

Education stored as JSON to support dynamic number of records.

⚙ Environment Variables (Production)
DATABASE_URL=postgresql://user:password@host/dbname
ASPNETCORE_ENVIRONMENT=Production

▶ Run Locally
Clone
git clone https://github.com/sp-108/Nova-Admin.git
cd Nova-Admin

Configure DB

Edit appsettings.json

"ConnectionStrings": {
  "DefaultConnection": "Server=.;Database=NovaAdmin;Trusted_Connection=True;TrustServerCertificate=True"
}

Apply Migration
dotnet ef database update

Run
dotnet run

🔄 Application Flow
Step 1 → Personal Details
Step 2 → Qualification
Step 3 → Address
Step 4 → Preview
Submit → Save to DB → Admin Panel

💼 Real-World Use Cases

College Admission Portal

Job Application Portal

Government Form System

Scholarship Registration

Survey Data Collection

👨‍💻 Author

Saurabh Prajapati
B.Tech CSE (AI)
Full-Stack Developer (.NET + AI + Systems)

GitHub: https://github.com/sp-108

⭐ Support

If you like this project — give it a star ⭐
It motivates a lot!

📣 Recruiter Note

This project demonstrates:

Backend architecture

DB modelling

Session state workflow

Production debugging

Deployment troubleshooting

Real-world form processing
