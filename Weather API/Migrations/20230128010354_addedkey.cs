using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WeatherAPI.Migrations
{
    /// <inheritdoc />
    public partial class addedkey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "weather",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_weather",
                table: "weather",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3fcffc8c-cb7c-4b83-b201-347fa2b4263f",
                column: "ConcurrencyStamp",
                value: "9f3319e6-ab72-42a4-b47a-86e2a6f58fd9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e9a390cc-138f-4011-814f-f5f79df8ceb7",
                column: "ConcurrencyStamp",
                value: "adb5a688-aec9-4b56-95d0-6ba2c1b00380");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30a24107-d279-4e37-96fd-01af5b38cb27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d1019c64-8dbd-4b30-8f34-1ef1e24f421b", "AQAAAAEAACcQAAAAEMasxAzjhGJYi0rMdmE+5qJMI2qFkwgdckZ//PQp60IyQanUJSntOKpEnZpy/EV2BA==", "cdba81fa-30a0-44e3-9a6e-2807d0e8c7ee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e448afa-f008-446e-a52f-13c449803c2e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "21db8069-3361-4f40-9ce4-c6a21286426c", "AQAAAAEAACcQAAAAEIoFkxg9n5B1+PAXT+/c8pzPOxm7kAP7+0tsLVrI3CkaieHuO4Ag04fjZRX6k9iw4A==", "d6e55696-a02d-4350-8850-52f0272cd0c1" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_weather",
                table: "weather");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "weather");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3fcffc8c-cb7c-4b83-b201-347fa2b4263f",
                column: "ConcurrencyStamp",
                value: "218caa23-c761-42e8-b9a4-c4723930f6b7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e9a390cc-138f-4011-814f-f5f79df8ceb7",
                column: "ConcurrencyStamp",
                value: "eba472bc-5d36-44de-b2ce-749ebadff58c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30a24107-d279-4e37-96fd-01af5b38cb27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eae2c272-b9a5-4221-b2ec-f8cc84954335", "AQAAAAEAACcQAAAAEIn6poPIrVsw29HzK1t1ixlBoG4CweI6Qv/C5tfF8UkgUsLXNqWViVv8tFtyOGcWGw==", "98be6084-2b67-4e13-aa63-d5e3be40d3b0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e448afa-f008-446e-a52f-13c449803c2e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e2ef224e-3b8d-4a92-baf9-2f787288d1f6", "AQAAAAEAACcQAAAAEAmnXU/FxUiH618Ls83ZKtCO8RElcddP6Fs9DR1OzIW6SR0lwPINGOqZt7kg5qHBUw==", "42b346e3-c3bd-49bc-aa3d-a85c8ff7cf5c" });
        }
    }
}
