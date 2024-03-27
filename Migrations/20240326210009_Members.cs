using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Corona_System.Migrations
{
    public partial class Members : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Member",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MobilePhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Vaccine1Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Vaccine1Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Vaccine2Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Vaccine2Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Vaccine3Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Vaccine3Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Vaccine4Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Vaccine4Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PositiveResultDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RecoveryDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Member", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Member");
        }
    }
}
