using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MultiStepFormApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialPostgres : Migration
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
                    Name = table.Column<string>(type: "text", nullable: true),
                    DOB = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Age = table.Column<int>(type: "integer", nullable: true),
                    Mobile = table.Column<string>(type: "text", nullable: true),
                    Aadhaar = table.Column<string>(type: "text", nullable: true),
                    Gender = table.Column<string>(type: "text", nullable: true),
                    MaritalStatus = table.Column<string>(type: "text", nullable: true),
                    FatherName = table.Column<string>(type: "text", nullable: true),
                    MotherName = table.Column<string>(type: "text", nullable: true),
                    FatherOccupation = table.Column<string>(type: "text", nullable: true),
                    MotherOccupation = table.Column<string>(type: "text", nullable: true),
                    Hobbies = table.Column<string>(type: "text", nullable: true),
                    Nationality = table.Column<string>(type: "text", nullable: true),
                    CorrAddress = table.Column<string>(type: "text", nullable: true),
                    CorrDistrict = table.Column<string>(type: "text", nullable: true),
                    CorrState = table.Column<string>(type: "text", nullable: true),
                    CorrCountry = table.Column<string>(type: "text", nullable: true),
                    CorrPincode = table.Column<string>(type: "text", nullable: true),
                    PermAddress = table.Column<string>(type: "text", nullable: true),
                    PermDistrict = table.Column<string>(type: "text", nullable: true),
                    PermState = table.Column<string>(type: "text", nullable: true),
                    PermCountry = table.Column<string>(type: "text", nullable: true),
                    PermPincode = table.Column<string>(type: "text", nullable: true),
                    EducationJson = table.Column<string>(type: "text", nullable: true)
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
