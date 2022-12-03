using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mpsPlatform.Infrastructure.Migrations
{
    public partial class IsDeletetCounters : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Counters",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a22ea8dd-3b74-436b-8bea-ed78cdf367a4", "AQAAAAEAACcQAAAAEH1CABU7tKhGh5TmQzCJC9R4rG4oerRpxm7K+I9PbUssFPZtysQlPopQApBqMSJvBw==", "490ff291-497a-4b9c-9f3d-bc1218f328e5" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Counters");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "20e4d656-5f06-44cb-92ff-c0537464da88", "AQAAAAEAACcQAAAAEF733o+SC4K67ONFEgFnEsMnKwEPhUM+T3yIekz9lYkrNf9mWh712CHb1OqveyjDcg==", "109a9938-6ab4-47c0-8770-c8d7010e986c" });
        }
    }
}
