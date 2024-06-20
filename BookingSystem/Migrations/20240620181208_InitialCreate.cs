using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingSystem.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClientDetails",
                columns: table => new
                {
                    ClientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ClientEmailId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ClientPanNo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ClientAadharNo = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    PreferFloors1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PreferFloors2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreferFloors3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AreaPreference = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CpName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CpEmailId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CpNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CpCompanyNameWithRERA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BankName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChequeNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChequeDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ChequeAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientDetails", x => x.ClientId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientDetails");
        }
    }
}
