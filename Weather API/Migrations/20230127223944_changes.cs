using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WeatherAPI.Migrations
{
    /// <inheritdoc />
    public partial class changes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3fcffc8c-cb7c-4b83-b201-347fa2b4263f",
                column: "ConcurrencyStamp",
                value: "d4adb44a-3e13-401d-8856-9e39b7cf2c38");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e9a390cc-138f-4011-814f-f5f79df8ceb7",
                column: "ConcurrencyStamp",
                value: "af5cdbb0-6842-4f40-a715-bfafdf5e2fb8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30a24107-d279-4e37-96fd-01af5b38cb27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "52bfbdf5-06d3-4311-a9f3-9ec7216d77af", "AQAAAAEAACcQAAAAEPSC6eVDn2cjoXKINi1/NtZUeLmY+B/z/6dBJOfQe5AZEODClpbd/cbW8vIwBvp7kQ==", "03912936-60c1-4b73-bc42-16c9cb2caaa9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e448afa-f008-446e-a52f-13c449803c2e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "86eb89cd-e461-42a4-b74a-a91ce65d5358", "AQAAAAEAACcQAAAAEE/zujKMWX0dR1ukjhvRARdBbJUrufTMEOepLLxvyzoLs++p3iBGHTquRDmryTXavQ==", "fe39377c-526f-4279-9b1e-cf2cc2ebbf01" });
        }
    }
}
