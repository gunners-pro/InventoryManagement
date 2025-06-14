using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventoryManagement.Api.Migrations
{
    /// <inheritdoc />
    public partial class AlterColumnTypeProductsForEnum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("CREATE TYPE product_category AS ENUM ('Clothing', 'Shoes', 'Bag', 'Jewelry', 'Acessories');");
            migrationBuilder.Sql("CREATE TYPE product_status AS ENUM('Active', 'OutOfStock')");

            migrationBuilder.Sql("ALTER TABLE products DROP COLUMN \"Category\";");
            migrationBuilder.Sql("ALTER TABLE products ADD COLUMN \"Category\" product_category NOT NULL;");
            migrationBuilder.Sql("ALTER TABLE products DROP COLUMN \"Status\";");
            migrationBuilder.Sql("ALTER TABLE products ADD COLUMN \"Status\" product_status NOT NULL;");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("ALTER TABLE products ALTER COLUMN \"Category\" TYPE int;");
            migrationBuilder.Sql("ALTER TABLE products ALTER COLUMN \"Status\" TYPE int;");

            migrationBuilder.Sql("DROP TYPE product_category;");
            migrationBuilder.Sql("DROP TYPE product_status;");
        }
    }
}
