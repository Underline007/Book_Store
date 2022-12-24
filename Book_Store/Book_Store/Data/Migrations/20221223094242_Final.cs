using Microsoft.EntityFrameworkCore.Migrations;

namespace Book_Store.Data.Migrations
{
    public partial class Final : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CatName",
                table: "Requests",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CatId",
                table: "Requests",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CatDescription",
                table: "Requests",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CatName",
                table: "Categories",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CatId",
                table: "Categories",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CatDescription",
                table: "Categories",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "A",
                column: "ConcurrencyStamp",
                value: "b922bc0f-dbce-4897-9415-48a4b78f6cb5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "C",
                column: "ConcurrencyStamp",
                value: "e32c7012-1d06-403e-968a-8050b9882f8e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "S",
                column: "ConcurrencyStamp",
                value: "8d6d79e2-9016-4a45-8af7-36b185b716dd");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6c77bdf6-e31e-467d-8c29-955aeb22d89f", "AQAAAAEAACcQAAAAEHYjROInXZuTJeiMXbh0HltHDsJIG7ZT8m9R5GG6z08pwDIGLvhc/zLw7GdSjagzpg==", "04d602fe-1e03-4909-86a5-825af1e8c645" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e7d0c68f-9c26-46fd-856f-547620cc0198", "AQAAAAEAACcQAAAAEPbpM2RTOX+MrQTs7OymATjTrHqUAdGDSn5szanZG4mYAnwR2nwqid+lsJxxTDboZw==", "ef2a4d69-dca8-465f-8e33-3795ea1586f3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bbaced2d-40bf-492d-bdd0-f15f5f8330d4", "AQAAAAEAACcQAAAAEF6lUNnq4u/J26yVfcDWuRV8Uef6oaNCeNQYCgpkA4o637/qszMnGwQVTL/8aBmBnQ==", "745c2309-14ad-4180-ac1d-adf35b839ef1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CatName",
                table: "Requests",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "CatId",
                table: "Requests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "CatDescription",
                table: "Requests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "CatName",
                table: "Categories",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "CatId",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "CatDescription",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

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
    }
}
