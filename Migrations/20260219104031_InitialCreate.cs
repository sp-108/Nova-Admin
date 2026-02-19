using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MultiStepFormApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: true),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aadhaar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaritalStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatherOccupation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherOccupation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hobbies = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CorrAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CorrDistrict = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CorrState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CorrCountry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CorrPincode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PermAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PermDistrict = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PermState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PermCountry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PermPincode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EducationJson = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
