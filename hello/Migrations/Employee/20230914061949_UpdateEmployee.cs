using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace hello.Migrations.Employee
{
    /// <inheritdoc />
    public partial class UpdateEmployee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "eamil",
                table: "Employees",
                newName: "email");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "email",
                table: "Employees",
                newName: "eamil");
        }
    }
}
