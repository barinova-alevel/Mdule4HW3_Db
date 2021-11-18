using Microsoft.EntityFrameworkCore.Migrations;

namespace MySolution.DataAccess.Migrations
{
    public partial class RenameDBSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Office_OfficeId",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Project_ProjectId",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Title_TitleId",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeProject_Employee_EmployeeId",
                table: "EmployeeProject");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employee",
                table: "Employee");

            migrationBuilder.RenameTable(
                name: "Employee",
                newName: "Employees");

            migrationBuilder.RenameIndex(
                name: "IX_Employee_TitleId",
                table: "Employees",
                newName: "IX_Employees_TitleId");

            migrationBuilder.RenameIndex(
                name: "IX_Employee_ProjectId",
                table: "Employees",
                newName: "IX_Employees_ProjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Employee_OfficeId",
                table: "Employees",
                newName: "IX_Employees_OfficeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeProject_Employees_EmployeeId",
                table: "EmployeeProject",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Office_OfficeId",
                table: "Employees",
                column: "OfficeId",
                principalTable: "Office",
                principalColumn: "OfficeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Project_ProjectId",
                table: "Employees",
                column: "ProjectId",
                principalTable: "Project",
                principalColumn: "ProjectId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Title_TitleId",
                table: "Employees",
                column: "TitleId",
                principalTable: "Title",
                principalColumn: "TitleId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeProject_Employees_EmployeeId",
                table: "EmployeeProject");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Office_OfficeId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Project_ProjectId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Title_TitleId",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "Employee");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_TitleId",
                table: "Employee",
                newName: "IX_Employee_TitleId");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_ProjectId",
                table: "Employee",
                newName: "IX_Employee_ProjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_OfficeId",
                table: "Employee",
                newName: "IX_Employee_OfficeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employee",
                table: "Employee",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Office_OfficeId",
                table: "Employee",
                column: "OfficeId",
                principalTable: "Office",
                principalColumn: "OfficeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Project_ProjectId",
                table: "Employee",
                column: "ProjectId",
                principalTable: "Project",
                principalColumn: "ProjectId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Title_TitleId",
                table: "Employee",
                column: "TitleId",
                principalTable: "Title",
                principalColumn: "TitleId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeProject_Employee_EmployeeId",
                table: "EmployeeProject",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
