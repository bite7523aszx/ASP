using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication3.Migrations
{
    public partial class test : Migration
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
                    Gender = table.Column<string>(maxLength: 1, nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Account = table.Column<string>(maxLength: 50, nullable: false),
                    Password = table.Column<string>(maxLength: 50, nullable: false),
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
                name: "Order",
                columns: table => new
                {
                    Order_number = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Order_date = table.Column<DateTime>(nullable: false),
                    Customer_number = table.Column<int>(nullable: false),
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
                name: "Purchase_quantitycs",
                columns: table => new
                {
                    Order_number = table.Column<int>(nullable: false),
                    Game_number = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purchase_quantitycs", x => new { x.Order_number, x.Game_number });
                    table.ForeignKey(
                        name: "FK_Purchase_quantitycs_Game_mall_Game_number",
                        column: x => x.Game_number,
                        principalTable: "Game_mall",
                        principalColumn: "Game_number",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Purchase_quantitycs_Order_Order_number",
                        column: x => x.Order_number,
                        principalTable: "Order",
                        principalColumn: "Order_number",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Order_Customer_ProfileCustomer_number",
                table: "Order",
                column: "Customer_ProfileCustomer_number");

            migrationBuilder.CreateIndex(
                name: "IX_Purchase_quantitycs_Game_number",
                table: "Purchase_quantitycs",
                column: "Game_number");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Purchase_quantitycs");

            migrationBuilder.DropTable(
                name: "Game_mall");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Customer_Profile");
        }
    }
}
