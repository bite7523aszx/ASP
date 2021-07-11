using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication3.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Customer_number",
                table: "Order",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<decimal>(
                name: "Total",
                table: "Order",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Customer_Profile",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Customer_Profile",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1);

            migrationBuilder.AlterColumn<string>(
                name: "Account",
                table: "Customer_Profile",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.CreateTable(
                name: "Game_mallComments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Comments = table.Column<string>(nullable: true),
                    PublishedDate = table.Column<DateTime>(nullable: false),
                    Comment_Game_number = table.Column<int>(nullable: false),
                    Game_mallsGame_number = table.Column<int>(nullable: true),
                    Rating = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Game_mallComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Game_mallComments_Game_mall_Game_mallsGame_number",
                        column: x => x.Game_mallsGame_number,
                        principalTable: "Game_mall",
                        principalColumn: "Game_number",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Game_order",
                columns: table => new
                {
                    Game_number = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Game_Serial = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Game_order", x => x.Game_number);
                });

            migrationBuilder.CreateTable(
                name: "Orderde",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Order_number = table.Column<int>(nullable: false),
                    Game_number = table.Column<int>(nullable: false),
                    Game_name = table.Column<string>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    Customer_number = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orderde", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "shopping",
                columns: table => new
                {
                    shoppingId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Game_name = table.Column<string>(nullable: false),
                    Game_category = table.Column<string>(nullable: false),
                    Unit_price = table.Column<int>(nullable: false),
                    quantity = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shopping", x => x.shoppingId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Game_mallComments_Game_mallsGame_number",
                table: "Game_mallComments",
                column: "Game_mallsGame_number");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Game_mallComments");

            migrationBuilder.DropTable(
                name: "Game_order");

            migrationBuilder.DropTable(
                name: "Orderde");

            migrationBuilder.DropTable(
                name: "shopping");

            migrationBuilder.DropColumn(
                name: "Total",
                table: "Order");

            migrationBuilder.AlterColumn<int>(
                name: "Customer_number",
                table: "Order",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Customer_Profile",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Customer_Profile",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Account",
                table: "Customer_Profile",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
