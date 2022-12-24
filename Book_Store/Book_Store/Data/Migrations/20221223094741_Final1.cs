using Microsoft.EntityFrameworkCore.Migrations;

namespace Book_Store.Data.Migrations
{
    public partial class Final1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SPicture",
                table: "StoreOwners",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SPhone",
                table: "StoreOwners",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SName",
                table: "StoreOwners",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CPhoneNumber",
                table: "Customers",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CName",
                table: "Customers",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CEmail",
                table: "Customers",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "CAddress",
                table: "Customers",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BName",
                table: "Books",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BDescription",
                table: "Books",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BAuthor",
                table: "Books",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "A",
                column: "ConcurrencyStamp",
                value: "b0b01b73-0b77-49f1-9fbc-d8646a8a584f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "C",
                column: "ConcurrencyStamp",
                value: "99e4e86f-e7a7-4f59-a5ba-6b70c472237d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "S",
                column: "ConcurrencyStamp",
                value: "85ca6900-26b5-4da4-97a7-ec7cc7638b22");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9f7d2c83-4cad-41be-b1c4-be9499f5b63e", "AQAAAAEAACcQAAAAEO9L0qrNpsP7I4IZWmWt0Jh+Ql/opXfq9rKURJEk6/kvB4llJ2E2oYy6wh/FrEaIjg==", "ae608304-a153-430b-b00a-28dee544b1e8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8017ff5f-d5b0-416c-8812-264e7f3e82eb", "AQAAAAEAACcQAAAAEMp5rzkTZVjefu9+tc8HG6CQFDZZYYpJHPBAQnWHjy0EwjeroYmXdSpeIlPEJUiF9Q==", "6b6d9148-56d8-497c-90e9-f07c7d53fa50" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ea8f654b-25ac-4bf0-808d-0381072bf6bc", "AQAAAAEAACcQAAAAEHbWvW5HOpcKR/mmI0ETnmk/N76Q795s7gbe4ZiTfuXxXBPxdAzAbe9ilvNTVqrhng==", "25b774a2-b5ec-4bce-9598-906929df3b75" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SPicture",
                table: "StoreOwners",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "SPhone",
                table: "StoreOwners",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "SName",
                table: "StoreOwners",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "CPhoneNumber",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "CName",
                table: "Customers",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "CEmail",
                table: "Customers",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "CAddress",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "BName",
                table: "Books",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "BDescription",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "BAuthor",
                table: "Books",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 30);

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
    }
}
