using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Toplearn.DataLayer.Migrations
{
    public partial class mig_ChangeUserAttributeAndDataType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserAvatar",
                table: "Users",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisterDate",
                table: "Users",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UserAvatar",
                table: "Users",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RegisterDate",
                table: "Users",
                nullable: true,
                oldClrType: typeof(DateTime));
        }
    }
}
