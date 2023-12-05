using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cupcakecom.Migrations
{
    public partial class UserOrderRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Application User",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ApplicationUserId",
                table: "Orders",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Application User",
                table: "Orders",
                column: "Application User");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_Application User",
                table: "Orders",
                column: "Application User",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_Application User",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_Application User",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Application User",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Orders");
        }
    }
}
