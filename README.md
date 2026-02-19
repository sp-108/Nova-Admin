<div align="center">
🪐 NOVA ADMIN
<sub>Multi-Step Application Form & Admin Management System</sub>
<br> <img src="https://img.shields.io/badge/.NET-8.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white"/> <img src="https://img.shields.io/badge/ASP.NET%20Core-MVC-5C2D91?style=for-the-badge&logo=dotnet"/> <img src="https://img.shields.io/badge/PostgreSQL-336791?style=for-the-badge&logo=postgresql&logoColor=white"/> <img src="https://img.shields.io/badge/Entity%20Framework-Core-6DB33F?style=for-the-badge"/> <img src="https://img.shields.io/badge/Hosted%20On-Render-000000?style=for-the-badge"/>

<br><br>

🌐 Live Website
👉 https://nova-admin-torz.onrender.com
</div>
<br>
**📖 About Project**

Nova Admin is a production-ready web application that simulates a real-world application portal
(College / Job / Scholarship / Government Form System).

Users fill a structured multi-step form → preview → submit → stored in PostgreSQL → managed through admin dashboard.

<br>
✨ Features
👤 Applicant Side

Multi step form navigation

Session based progress saving

Preview before submit

Edit before final submission

Validation protected form

🛠 Admin Panel

View all applicants

Detailed profile view

Edit record

Delete record

Dynamic education rendering (JSON → UI)

⚙ Backend System

ASP.NET Core MVC (.NET 8)

Entity Framework Core

PostgreSQL integration

Automatic migrations on deploy

Production error handling

☁ Deployment

Hosted on Render

External PostgreSQL Database

Environment variable configuration

Secure SSL database connection

<br>
🧱 Tech Stack
Layer	Technology
Frontend	Razor Views + Bootstrap
Backend	ASP.NET Core MVC
ORM	Entity Framework Core
Database	PostgreSQL
Hosting	Render
Session	ASP.NET Core Session
Serialization	System.Text.Json
<br>
🗂 Project Structure
Nova-Admin
│
├── Controllers
│   ├── FormController
│   ├── AdminController
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
│
├── Data
│   └── ApplicationDbContext
│
└── Program.cs

<br>
🗄 Database Design

Main Table → FormEntries

Stores:

Personal Info

Contact Info

Address

Education (stored as JSON)

JSON used because education entries are dynamic in count.

<br>
▶ Run Locally
Clone Repository
git clone https://github.com/sp-108/Nova-Admin.git
cd Nova-Admin

Setup Database

Edit appsettings.json

"ConnectionStrings": {
  "DefaultConnection": "Server=.;Database=NovaAdmin;Trusted_Connection=True;TrustServerCertificate=True"
}

Apply Migration
dotnet ef database update

Run Project
dotnet run

<br>
🔄 Application Flow
Personal → Qualification → Address → Preview → Submit → Database → Admin Panel

<br>
💼 Use Cases

College Admission Portal

Job Application Portal

Government Registration System

Scholarship Application

Survey Data Collection

<br>
👨‍💻 Author

Saurabh Prajapati
B.Tech CSE (AI) — Full Stack Developer

GitHub → https://github.com/sp-108

<br> <div align="center">
⭐ If you like this project, give it a star ⭐
</div>
🧾 END
