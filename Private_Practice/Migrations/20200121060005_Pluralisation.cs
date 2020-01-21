using Microsoft.EntityFrameworkCore.Migrations;

namespace Private_Practice.Migrations
{
    public partial class Pluralisation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Visit_ClientId",
                table: "Visit",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Visit_DoctorId",
                table: "Visit",
                column: "DoctorId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Visit_Clients_ClientId",
                table: "Visit");

            migrationBuilder.DropForeignKey(
                name: "FK_Visit_Doctors_DoctorId",
                table: "Visit");

            migrationBuilder.DropIndex(
                name: "IX_Visit_ClientId",
                table: "Visit");

            migrationBuilder.DropIndex(
                name: "IX_Visit_DoctorId",
                table: "Visit");
        }
    }
}
