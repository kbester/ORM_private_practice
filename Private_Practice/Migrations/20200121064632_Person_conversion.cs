using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Private_Practice.Migrations
{
    public partial class Person_conversion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Visit_Clients_ClientId",
                table: "Visit");

            migrationBuilder.DropForeignKey(
                name: "FK_Visit_Doctors_DoctorId",
                table: "Visit");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Doctors",
                table: "Doctors");

            migrationBuilder.RenameTable(
                name: "Doctors",
                newName: "Persons");

            migrationBuilder.AlterColumn<Guid>(
                name: "DoctorId",
                table: "Persons",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "ClientId",
                table: "Persons",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "IllnessId",
                table: "Persons",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Persons",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Persons",
                table: "Persons",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Visit_Persons_ClientId",
                table: "Visit",
                column: "ClientId",
                principalTable: "Persons",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Visit_Persons_DoctorId",
                table: "Visit",
                column: "DoctorId",
                principalTable: "Persons",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Visit_Persons_ClientId",
                table: "Visit");

            migrationBuilder.DropForeignKey(
                name: "FK_Visit_Persons_DoctorId",
                table: "Visit");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Persons",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "IllnessId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Persons");

            migrationBuilder.RenameTable(
                name: "Persons",
                newName: "Doctors");

            migrationBuilder.AlterColumn<Guid>(
                name: "DoctorId",
                table: "Doctors",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Doctors",
                table: "Doctors",
                column: "DoctorId");

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    ContactNo = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: true),
                    IdNumber = table.Column<int>(type: "int", nullable: false),
                    IllnessId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ClientId);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Visit_Clients_ClientId",
                table: "Visit",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "ClientId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Visit_Doctors_DoctorId",
                table: "Visit",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "DoctorId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
