using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore.PL.Migrations
{
    /// <inheritdoc />
    public partial class IndexNameonEmployeeId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameIndex(
                name: "IX_Employees_EmployeeId",
                table: "Employees",
                newName: "IN_EmployeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameIndex(
                name: "IN_EmployeeId",
                table: "Employees",
                newName: "IX_Employees_EmployeeId");
        }
    }
}
