using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MultiStepFormApp.Migrations
{
    /// <inheritdoc />
    public partial class InitPostgres : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FormEntries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aadhaar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaritalStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FatherName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MotherName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FatherOccupation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MotherOccupation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hobbies = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CorrAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CorrDistrict = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CorrState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CorrCountry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CorrPincode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PermAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PermDistrict = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PermState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PermCountry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PermPincode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EducationJson = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormEntries", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FormEntries");
        }
    }
}
