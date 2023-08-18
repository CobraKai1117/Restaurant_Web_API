using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restaurant_Web_API.Migrations
{
    /// <inheritdoc />
    public partial class Restaurant_Web_APIDatabaseClassRestaurantContextcs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RestaurantSet",
                columns: table => new
                {
                    RestaurantId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    business_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    business_address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    business_city = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    business_state = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    business_postal_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    inspection_id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    inspection_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    inspection_score = table.Column<int>(type: "int", nullable: true),
                    inspection_type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    violation_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    violation_description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    risk_category = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestaurantSet", x => x.RestaurantId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RestaurantSet");
        }
    }
}
