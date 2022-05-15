using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class LenghtCorrection_Ids : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "WarehouseId",
                keyValue: "c266b3ed-5be1-40c0-833c-b962e0d1f233");

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "WarehouseId",
                keyValue: "c392fdb9-6f1c-494b-987f-adf057bed01a");

            migrationBuilder.AlterColumn<string>(
                name: "ProductId",
                table: "Storages",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProductId",
                table: "Products",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.InsertData(
                table: "Warehouse",
                columns: new[] { "WarehouseId", "WarehouseAddress", "WarehouseName" },
                values: new object[] { "c44a0b22-313d-4c34-b720-54d3f573c592", "4627 Rowes Lane. Louisville, Ky", "Bodega Central" });

            migrationBuilder.InsertData(
                table: "Warehouse",
                columns: new[] { "WarehouseId", "WarehouseAddress", "WarehouseName" },
                values: new object[] { "323e50a1-40b6-4ca1-8adf-2b41c884a0f9", "4085 North Street. Salt Lake City, Utah", "Bodega Norte" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "WarehouseId",
                keyValue: "323e50a1-40b6-4ca1-8adf-2b41c884a0f9");

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "WarehouseId",
                keyValue: "c44a0b22-313d-4c34-b720-54d3f573c592");

            migrationBuilder.AlterColumn<string>(
                name: "ProductId",
                table: "Storages",
                type: "nvarchar(10)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProductId",
                table: "Products",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.InsertData(
                table: "Warehouse",
                columns: new[] { "WarehouseId", "WarehouseAddress", "WarehouseName" },
                values: new object[] { "c266b3ed-5be1-40c0-833c-b962e0d1f233", "4627 Rowes Lane. Louisville, Ky", "Bodega Central" });

            migrationBuilder.InsertData(
                table: "Warehouse",
                columns: new[] { "WarehouseId", "WarehouseAddress", "WarehouseName" },
                values: new object[] { "c392fdb9-6f1c-494b-987f-adf057bed01a", "4085 North Street. Salt Lake City, Utah", "Bodega Norte" });
        }
    }
}
