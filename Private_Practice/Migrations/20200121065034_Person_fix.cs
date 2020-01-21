using Microsoft.EntityFrameworkCore.Migrations;

namespace Private_Practice.Migrations
{
    public partial class Person_fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Visit_Persons_ClientId",
                table: "Visit");

            migrationBuilder.DropForeignKey(
                name: "FK_Visit_Persons_DoctorId",
                table: "Visit");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Visit",
                table: "Visit");

            migrationBuilder.RenameTable(
                name: "Visit",
                newName: "Visits");

            migrationBuilder.RenameIndex(
                name: "IX_Visit_DoctorId",
                table: "Visits",
                newName: "IX_Visits_DoctorId");

            migrationBuilder.RenameIndex(
                name: "IX_Visit_ClientId",
                table: "Visits",
                newName: "IX_Visits_ClientId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Visits",
                table: "Visits",
                column: "VisitId");

            migrationBuilder.AddForeignKey(
                name: "FK_Visits_Persons_ClientId",
                table: "Visits",
                column: "ClientId",
                principalTable: "Persons",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Visits_Persons_DoctorId",
                table: "Visits",
                column: "DoctorId",
                principalTable: "Persons",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Visits_Persons_ClientId",
                table: "Visits");

            migrationBuilder.DropForeignKey(
                name: "FK_Visits_Persons_DoctorId",
                table: "Visits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Visits",
                table: "Visits");

            migrationBuilder.RenameTable(
                name: "Visits",
                newName: "Visit");

            migrationBuilder.RenameIndex(
                name: "IX_Visits_DoctorId",
                table: "Visit",
                newName: "IX_Visit_DoctorId");

            migrationBuilder.RenameIndex(
                name: "IX_Visits_ClientId",
                table: "Visit",
                newName: "IX_Visit_ClientId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Visit",
                table: "Visit",
                column: "VisitId");

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
    }
}
