using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication3.Migrations.GameVIew
{
    public partial class Order : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer_Profile",
                columns: table => new
                {
                    Customer_number = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Customer_name = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Account = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Game_point = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer_Profile", x => x.Customer_number);
                });

            migrationBuilder.CreateTable(
                name: "Game_mall",
                columns: table => new
                {
                    Game_number = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Game_name = table.Column<string>(nullable: false),
                    Game_category = table.Column<string>(nullable: false),
                    Unit_price = table.Column<int>(nullable: false),
                    Listing_date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Game_mall", x => x.Game_number);
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
                    Guid = table.Column<string>(nullable: false),
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

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Order_number = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Order_date = table.Column<DateTime>(nullable: false),
                    Customer_number = table.Column<string>(nullable: true),
                    Total = table.Column<decimal>(nullable: false),
                    Customer_ProfileCustomer_number = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Order_number);
                    table.ForeignKey(
                        name: "FK_Order_Customer_Profile_Customer_ProfileCustomer_number",
                        column: x => x.Customer_ProfileCustomer_number,
                        principalTable: "Customer_Profile",
                        principalColumn: "Customer_number",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Game_mallComment",
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
                    table.PrimaryKey("PK_Game_mallComment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Game_mallComment_Game_mall_Game_mallsGame_number",
                        column: x => x.Game_mallsGame_number,
                        principalTable: "Game_mall",
                        principalColumn: "Game_number",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Purchase_quantitycs",
                columns: table => new
                {
                    Order_number = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Game_number = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Order_number1 = table.Column<int>(nullable: true),
                    Game_mallGame_number = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purchase_quantitycs", x => x.Order_number);
                    table.ForeignKey(
                        name: "FK_Purchase_quantitycs_Game_mall_Game_mallGame_number",
                        column: x => x.Game_mallGame_number,
                        principalTable: "Game_mall",
                        principalColumn: "Game_number",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Purchase_quantitycs_Order_Order_number1",
                        column: x => x.Order_number1,
                        principalTable: "Order",
                        principalColumn: "Order_number",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Game_mallComment_Game_mallsGame_number",
                table: "Game_mallComment",
                column: "Game_mallsGame_number");

            migrationBuilder.CreateIndex(
                name: "IX_Order_Customer_ProfileCustomer_number",
                table: "Order",
                column: "Customer_ProfileCustomer_number");

            migrationBuilder.CreateIndex(
                name: "IX_Purchase_quantitycs_Game_mallGame_number",
                table: "Purchase_quantitycs",
                column: "Game_mallGame_number");

            migrationBuilder.CreateIndex(
                name: "IX_Purchase_quantitycs_Order_number1",
                table: "Purchase_quantitycs",
                column: "Order_number1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Game_mallComment");

            migrationBuilder.DropTable(
                name: "Orderde");

            migrationBuilder.DropTable(
                name: "Purchase_quantitycs");

            migrationBuilder.DropTable(
                name: "shopping");

            migrationBuilder.DropTable(
                name: "Game_mall");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Customer_Profile");
        }
    }
}
