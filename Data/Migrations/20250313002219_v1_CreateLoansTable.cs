using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryVirtual.Migrations
{
    /// <inheritdoc />
    public partial class v1_CreateLoansTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Loans",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Recipient = table.Column<string>(type: "NVARCHAR(120)", maxLength: 120, nullable: false),
                    Supplier = table.Column<string>(type: "NVARCHAR(120)", maxLength: 120, nullable: false),
                    BorrowedBook = table.Column<string>(type: "NVARCHAR(255)", maxLength: 255, nullable: false),
                    LoanDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loans", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Loans");
        }
    }
}
