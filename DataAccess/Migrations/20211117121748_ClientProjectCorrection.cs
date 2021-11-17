using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MySolution.DataAccess.Migrations
{
    public partial class ClientProjectCorrection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Client_Project_ProjectId",
                table: "Client");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Client",
                table: "Client");

            migrationBuilder.DropIndex(
                name: "IX_Client_ProjectId",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "Client");

            migrationBuilder.RenameTable(
                name: "Client",
                newName: "Clients");

            migrationBuilder.RenameColumn(
                name: "FirstOrder",
                table: "Clients",
                newName: "ClientSince");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Clients",
                newName: "First Name");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Clients",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "First Name",
                table: "Clients",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clients",
                table: "Clients",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Email", "First Name", "ClientSince", "LastName" },
                values: new object[,]
                {
                    { 1, "mail1@mail.se", "Client1", new DateTime(2020, 5, 9, 9, 15, 0, 0, DateTimeKind.Unspecified), "LastNameClient 2" },
                    { 2, "mail2@mail.se", "Client2", new DateTime(2020, 5, 9, 9, 15, 0, 0, DateTimeKind.Unspecified), "LastNameClient 2" },
                    { 3, "mail3@mail.se", "Client3", new DateTime(2020, 5, 9, 9, 15, 0, 0, DateTimeKind.Unspecified), "LastNameClient 2" },
                    { 4, "mail4@mail.se", "Client4", new DateTime(2020, 5, 9, 9, 15, 0, 0, DateTimeKind.Unspecified), "LastNameClient 2" },
                    { 5, "mail5@mail.se", "Client5", new DateTime(2020, 5, 9, 9, 15, 0, 0, DateTimeKind.Unspecified), "LastNameClient 2" }
                });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 1,
                column: "ClientId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 2,
                column: "ClientId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 3,
                column: "ClientId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 4,
                column: "ClientId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 5,
                column: "ClientId",
                value: 3);

            migrationBuilder.CreateIndex(
                name: "IX_Project_ClientId",
                table: "Project",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Project_Clients_ClientId",
                table: "Project",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Project_Clients_ClientId",
                table: "Project");

            migrationBuilder.DropIndex(
                name: "IX_Project_ClientId",
                table: "Project");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clients",
                table: "Clients");

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.RenameTable(
                name: "Clients",
                newName: "Client");

            migrationBuilder.RenameColumn(
                name: "First Name",
                table: "Client",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "ClientSince",
                table: "Client",
                newName: "FirstOrder");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Client",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Client",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<int>(
                name: "ProjectId",
                table: "Client",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Client",
                table: "Client",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 1,
                column: "ClientId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 2,
                column: "ClientId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 3,
                column: "ClientId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 4,
                column: "ClientId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 5,
                column: "ClientId",
                value: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Client_ProjectId",
                table: "Client",
                column: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Client_Project_ProjectId",
                table: "Client",
                column: "ProjectId",
                principalTable: "Project",
                principalColumn: "ProjectId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
