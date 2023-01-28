using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WeatherAPI.Migrations
{
    /// <inheritdoc />
    public partial class newMigrationadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                value: "a43d9e1e-49b8-4bab-add7-9c10643da67d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e9a390cc-138f-4011-814f-f5f79df8ceb7",
                column: "ConcurrencyStamp",
                value: "09d79b0c-3347-4534-9a38-da62cecfd2d2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30a24107-d279-4e37-96fd-01af5b38cb27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e78e21a8-7a9c-4863-8db5-ff9e3a34129a", "AQAAAAEAACcQAAAAELWV6CY6EpcanTTdsrgz8SLQnUJvKHSSeZOBzw4UqwUZzOuDQzMgU+TH1KtzylIf+g==", "ce1ca161-e2db-4b19-9b14-232535f6d98a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e448afa-f008-446e-a52f-13c449803c2e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7362f338-d8e6-4943-af68-e56ced5ceca8", "AQAAAAEAACcQAAAAEAXNKoDUs5bbtuTJzlYQ6559pOdIBb0DwJJPmMptWNcoOyC54lGSgvwEbeferQQp9A==", "dbdb53ce-2e04-4a0c-9b14-cf14f3a4b1c4" });
        }
    }
}
