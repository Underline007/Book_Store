using Microsoft.EntityFrameworkCore.Migrations;

namespace Book_Store.Data.Migrations
{
    public partial class a : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "A",
                column: "ConcurrencyStamp",
                value: "583e9ac7-4408-417c-9c12-cdeaa7c5ba0f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "C",
                column: "ConcurrencyStamp",
                value: "0fdb2963-b1d4-4592-bd7d-3dd0ac9cc8d9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "S",
                column: "ConcurrencyStamp",
                value: "3afc690e-b4c2-4a1e-9f20-8858e9f10a8f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "63a3375a-e5b4-4470-8f8f-7eeaad580d98", "AQAAAAEAACcQAAAAEAgwQAw+h2xcsh0eJh/4OcMJqMPmOIAeL8KwhbiIHVJLNEFMcZnEd87VGFZ9uV6iMQ==", "5c1f274b-c5e2-488f-905c-6cc1b6025ebf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8905df1f-b127-4e6f-ab16-d4d2942f7085", "AQAAAAEAACcQAAAAEFs+8Sqg64tSd5oGrA+TCKPrOB/p+XwWm04Hn9vsmbLNPI8tA1Y8NLWhDol+fAiqiw==", "48b58657-1d6d-40b5-b132-888719a6e8a4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2f1fe415-4939-40d8-84d7-55f502bc8a14", "AQAAAAEAACcQAAAAEACYIesTNqcHeG3u68c+t1k0YK1oGWzszyZBaUDBqtdQwqs8Y4ssX1ykmmRGG9m0JQ==", "65e90696-81a2-4164-8b34-f93cd5baa9dc" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4", 0, "7cc2865e-c575-4e5d-9aa1-c1a97119d236", "anhltp@fpt.edu.vn", true, false, null, null, "anhltp@fpt.edu.vn", "AQAAAAEAACcQAAAAEDHG2nddZ5p6ZtXz7tRgYShWcFvrrzXm6RIE9mRRwrVIEZxmx37tetOIyk8e3oUh7A==", null, false, "ff4bc7fa-ed67-422a-b8e3-2160320d42b5", false, "ad_leanh" },
                    { "5", 0, "bc8eaf4d-496f-4049-ac41-d98cf50ef2af", "duonghtt@fpt.edu.vn", true, false, null, null, "duonghtt@fpt.edu.vn", "AQAAAAEAACcQAAAAEP/ASaQiogKr0vv1SKc8JSQ1fQuG1CZlFh3GSrCfvhOyjfPtlPazb/uLdINCb0t65w==", null, false, "c046db1c-b3b0-4ab8-9392-f325eb1fd5fa", false, "s_duong" },
                    { "6", 0, "239dca39-c9e0-40d5-a6bb-9a0fd0267ccf", "minhlt@gmail.com", true, false, null, null, "minhlt@gmail.com", "AQAAAAEAACcQAAAAEO+fy772UWH3/2ZvH7JCambzNVRoeTrIAkeQjnkRIaXLVj1c5vD3W6JkweKYytqhkg==", null, false, "47a1b928-8e6d-4eb0-b6a5-71a8d96efacf", false, "cus_minh" }
                });
        }
    }
}
