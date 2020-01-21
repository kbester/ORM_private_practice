using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Private_Practice.Migrations
{
    public partial class FK_reassignment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "IllnessId",
                table: "Illnesses",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<Guid>(
                name: "IllnessId",
                table: "Clients",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "IllnessId",
                table: "Illnesses",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<string>(
                name: "IllnessId",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(Guid));
        }
    }
}
