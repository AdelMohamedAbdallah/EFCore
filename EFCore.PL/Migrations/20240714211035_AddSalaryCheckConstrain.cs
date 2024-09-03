using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore.PL.Migrations
{
    /// <inheritdoc />
    public partial class AddSalaryCheckConstrain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddCheckConstraint(
                name: "CK_Salary",
                table: "Employees",
                sql: "[Salary] between 1000 and 8000");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "CK_Salary",
                table: "Employees");
        }
    }
}
