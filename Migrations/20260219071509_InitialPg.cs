using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MultiStepFormApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialPg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FormEntries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    DOB = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Age = table.Column<int>(type: "integer", nullable: false),
                    Mobile = table.Column<string>(type: "text", nullable: false),
                    Aadhaar = table.Column<string>(type: "text", nullable: false),
                    Gender = table.Column<string>(type: "text", nullable: false),
                    MaritalStatus = table.Column<string>(type: "text", nullable: false),
                    FatherName = table.Column<string>(type: "text", nullable: false),
                    MotherName = table.Column<string>(type: "text", nullable: false),
                    FatherOccupation = table.Column<string>(type: "text", nullable: false),
                    MotherOccupation = table.Column<string>(type: "text", nullable: false),
                    Hobbies = table.Column<string>(type: "text", nullable: false),
                    Nationality = table.Column<string>(type: "text", nullable: false),
                    CorrAddress = table.Column<string>(type: "text", nullable: false),
                    CorrDistrict = table.Column<string>(type: "text", nullable: false),
                    CorrState = table.Column<string>(type: "text", nullable: false),
                    CorrCountry = table.Column<string>(type: "text", nullable: false),
                    CorrPincode = table.Column<string>(type: "text", nullable: false),
                    PermAddress = table.Column<string>(type: "text", nullable: false),
                    PermDistrict = table.Column<string>(type: "text", nullable: false),
                    PermState = table.Column<string>(type: "text", nullable: false),
                    PermCountry = table.Column<string>(type: "text", nullable: false),
                    PermPincode = table.Column<string>(type: "text", nullable: false),
                    EducationJson = table.Column<string>(type: "text", nullable: false)
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
