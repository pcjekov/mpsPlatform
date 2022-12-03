using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mpsPlatform.Infrastructure.Migrations
{
    public partial class IsDeleted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "SpareParts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "SerialNumbers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Manufacturers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Locations",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "InstallersPeople",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Customers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Contract",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "ЕquipmentModels",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "20e4d656-5f06-44cb-92ff-c0537464da88", "AQAAAAEAACcQAAAAEF733o+SC4K67ONFEgFnEsMnKwEPhUM+T3yIekz9lYkrNf9mWh712CHb1OqveyjDcg==", "109a9938-6ab4-47c0-8770-c8d7010e986c" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "SpareParts");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "SerialNumbers");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Manufacturers");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "InstallersPeople");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Contract");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "ЕquipmentModels");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "740560d3-c595-4fb8-8bcc-d1623c07fcf0", "AQAAAAEAACcQAAAAENtI4RTB6BbhZ0usbNXhTyO4qv44tclvnsyIHQMtNVpSQ/kfRMMsMaTmf7r/TsYv0w==", "216cb4ba-d031-4ac7-87a2-2bfb3a84f1ac" });
        }
    }
}
