using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorPages.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StartCity = table.Column<string>(type: "TEXT", maxLength: 60, nullable: false),
                    StartAdress = table.Column<string>(type: "TEXT", maxLength: 60, nullable: false),
                    FinishCity = table.Column<string>(type: "TEXT", maxLength: 60, nullable: false),
                    FinishAdress = table.Column<string>(type: "TEXT", maxLength: 60, nullable: false),
                    Weight = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Order");
        }
    }
}
