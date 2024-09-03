using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore.PL.Migrations
{
    /// <inheritdoc />
    public partial class IndexInEmployeeId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Employees_EmployeeId",
                table: "Employees",
                column: "EmployeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Employees_EmployeeId",
                table: "Employees");
        }
    }
}
