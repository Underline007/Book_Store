using Microsoft.EntityFrameworkCore.Migrations;

namespace Book_Store.Data.Migrations
{
    public partial class alcv : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CEmail",
                table: "Customers",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "A",
                column: "ConcurrencyStamp",
                value: "f99fc64a-6d5c-458e-9c12-8e06b44a75ee");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "C",
                column: "ConcurrencyStamp",
                value: "f1a7c42a-6b19-4a28-96e9-6f09e00dc96a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "S",
                column: "ConcurrencyStamp",
                value: "87d0ed5e-be89-4094-a034-ff57ea41d4da");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "26f5ed1a-5cd0-443a-913f-3ec65335d18e", "AQAAAAEAACcQAAAAEHmcKOJ4F/z8FttMT18wpKxLH7j2eLkhkKEZS5q7ZHlNvayMwj+XVvoLYw2alOL2OQ==", "01e68015-b0d0-437f-b0c2-65f84caf692d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "af40a094-9e28-45d4-be9d-0ed9b638408e", "AQAAAAEAACcQAAAAEG7Lcs56VLzi0NyLH+5/RcKZcRccaRkOcf3CYuI2qwUe14uwrizONndl316Rwl2nJw==", "6957c4f0-c5ac-473c-a464-5d5c37454ff1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4965c30f-9781-45da-88bc-510eb6dd442b", "AQAAAAEAACcQAAAAEFkv5wyIlI9KtS1k7jsSwB1RtrfNv+SlJ1VaLgZzV9q8R6n9ThlQYwoQIcukgQPbmw==", "f1578649-d0f4-472f-a26e-7c77378c26f2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7cc2865e-c575-4e5d-9aa1-c1a97119d236", "AQAAAAEAACcQAAAAEDHG2nddZ5p6ZtXz7tRgYShWcFvrrzXm6RIE9mRRwrVIEZxmx37tetOIyk8e3oUh7A==", "ff4bc7fa-ed67-422a-b8e3-2160320d42b5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bc8eaf4d-496f-4049-ac41-d98cf50ef2af", "AQAAAAEAACcQAAAAEP/ASaQiogKr0vv1SKc8JSQ1fQuG1CZlFh3GSrCfvhOyjfPtlPazb/uLdINCb0t65w==", "c046db1c-b3b0-4ab8-9392-f325eb1fd5fa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "239dca39-c9e0-40d5-a6bb-9a0fd0267ccf", "AQAAAAEAACcQAAAAEO+fy772UWH3/2ZvH7JCambzNVRoeTrIAkeQjnkRIaXLVj1c5vD3W6JkweKYytqhkg==", "47a1b928-8e6d-4eb0-b6a5-71a8d96efacf" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CEmail",
                table: "Customers",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "A",
                column: "ConcurrencyStamp",
                value: "3d5188c5-d11d-4963-959b-0eeae896ab86");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "C",
                column: "ConcurrencyStamp",
                value: "d3cb23be-3204-4fd1-886a-11f2df444441");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "S",
                column: "ConcurrencyStamp",
                value: "2c467bc0-b1b1-45dc-a827-2894b93c9c53");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "46d71ee0-eb32-467e-9ffa-a7f665d0c911", "AQAAAAEAACcQAAAAEF7/MbcEWAh230uA7t975s2wv/SrdeeRkY3wO0yXYKWKlZuT/O6kJ+zwuuPyHbgs7g==", "43dd6f0f-35eb-441a-904b-99e51f2f1b3d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5d0a390b-1bf9-4d68-8a71-6e08150aa4fb", "AQAAAAEAACcQAAAAEN3OVu4y5bggAlqzB6w7ZYt8VTtNZol/cYXiTO3zlHwdzXo3xIGH11Wz0tToxkPwhw==", "7a2a3a70-f143-422a-b2bc-0755883b5c5b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ea98598-2698-46dc-a033-b6aeaad2eeb6", "AQAAAAEAACcQAAAAEDfjHPZG+AqjBConhlWbpiyFVf1x2pPNJqrFTOWtgHr9y0yl4cdVH3A4MsoFqHrLcA==", "81c931df-e889-47b7-a54d-29334b598a9d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b17f9da-5c17-41b1-a2a7-e5a6c9373b00", "AQAAAAEAACcQAAAAEBFB/OmNCvKx+Woa0OCAEgC72DPe2utop24RXRa8DdugbV4x0owswY4uaVF5tvV1nQ==", "c22e41a8-1961-4434-81ae-33011ae15968" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "be303d5f-d517-4e62-9af4-8681dc3c22f5", "AQAAAAEAACcQAAAAECMKoipLH4isPlLccnbP76ZPTxMbm9mMS/uzMIq/d9naFMBY0bUwVmPYDTU+eretDQ==", "77e560ab-41da-4629-aac7-5d5952c72aa8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5989a945-c020-4dbe-acf7-e19fb85f7878", "AQAAAAEAACcQAAAAEENaGqkUVu8lwv4l7GyqUksUrIy3UrP0jp0q+VVA8+eH4e3tsmRvaQmx34l9EAeERA==", "5a175391-0c22-40be-aa62-e207f9f63cc0" });
        }
    }
}
