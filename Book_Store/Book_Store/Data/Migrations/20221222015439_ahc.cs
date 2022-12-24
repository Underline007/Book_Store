using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Book_Store.Data.Migrations
{
    public partial class ahc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CatId = table.Column<string>(nullable: true),
                    CatName = table.Column<string>(maxLength: 30, nullable: true),
                    CatDescription = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CName = table.Column<string>(maxLength: 20, nullable: true),
                    CAddress = table.Column<string>(nullable: true),
                    CEmail = table.Column<string>(maxLength: 10, nullable: false),
                    CGender = table.Column<string>(nullable: false),
                    CBirthday = table.Column<DateTime>(nullable: false),
                    CPhoneNumber = table.Column<string>(nullable: true),
                    CPicture = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Requests",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CatId = table.Column<string>(nullable: true),
                    CatName = table.Column<string>(maxLength: 30, nullable: true),
                    CatDescription = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StoreOwners",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SName = table.Column<string>(maxLength: 20, nullable: true),
                    SPhone = table.Column<string>(maxLength: 10, nullable: true),
                    SGender = table.Column<string>(nullable: false),
                    SPicture = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreOwners", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<string>(nullable: true),
                    BName = table.Column<string>(maxLength: 30, nullable: true),
                    BPrice = table.Column<double>(nullable: false),
                    BQuantity = table.Column<int>(nullable: false),
                    BDescription = table.Column<string>(nullable: true),
                    BPicture = table.Column<string>(nullable: false),
                    BAuthor = table.Column<string>(maxLength: 30, nullable: true),
                    CategoryId = table.Column<int>(nullable: false),
                    RequestId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Books_Requests_RequestId",
                        column: x => x.RequestId,
                        principalTable: "Requests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Customer = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Image = table.Column<string>(nullable: true),
                    BookId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "A", "3d5188c5-d11d-4963-959b-0eeae896ab86", "Administrator", "Administrator" },
                    { "S", "2c467bc0-b1b1-45dc-a827-2894b93c9c53", "storeOwner", "storeOwner" },
                    { "C", "d3cb23be-3204-4fd1-886a-11f2df444441", "Customer", "Customer" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, "46d71ee0-eb32-467e-9ffa-a7f665d0c911", "dung@gmail.com", true, false, null, null, "dung@gmail.com", "AQAAAAEAACcQAAAAEF7/MbcEWAh230uA7t975s2wv/SrdeeRkY3wO0yXYKWKlZuT/O6kJ+zwuuPyHbgs7g==", null, false, "43dd6f0f-35eb-441a-904b-99e51f2f1b3d", false, "Dung" },
                    { "2", 0, "5d0a390b-1bf9-4d68-8a71-6e08150aa4fb", "truong@gmail.com", true, false, null, null, "truong@gmail.com", "AQAAAAEAACcQAAAAEN3OVu4y5bggAlqzB6w7ZYt8VTtNZol/cYXiTO3zlHwdzXo3xIGH11Wz0tToxkPwhw==", null, false, "7a2a3a70-f143-422a-b2bc-0755883b5c5b", false, "Truong" },
                    { "3", 0, "1ea98598-2698-46dc-a033-b6aeaad2eeb6", "dat@gmail.com", true, false, null, null, "dat@gmail.com", "AQAAAAEAACcQAAAAEDfjHPZG+AqjBConhlWbpiyFVf1x2pPNJqrFTOWtgHr9y0yl4cdVH3A4MsoFqHrLcA==", null, false, "81c931df-e889-47b7-a54d-29334b598a9d", false, "Dat" },
                    { "4", 0, "2b17f9da-5c17-41b1-a2a7-e5a6c9373b00", "anhltp@fpt.edu.vn", true, false, null, null, "anhltp@fpt.edu.vn", "AQAAAAEAACcQAAAAEBFB/OmNCvKx+Woa0OCAEgC72DPe2utop24RXRa8DdugbV4x0owswY4uaVF5tvV1nQ==", null, false, "c22e41a8-1961-4434-81ae-33011ae15968", false, "ad_leanh" },
                    { "5", 0, "be303d5f-d517-4e62-9af4-8681dc3c22f5", "duonghtt@fpt.edu.vn", true, false, null, null, "duonghtt@fpt.edu.vn", "AQAAAAEAACcQAAAAECMKoipLH4isPlLccnbP76ZPTxMbm9mMS/uzMIq/d9naFMBY0bUwVmPYDTU+eretDQ==", null, false, "77e560ab-41da-4629-aac7-5d5952c72aa8", false, "s_duong" },
                    { "6", 0, "5989a945-c020-4dbe-acf7-e19fb85f7878", "minhlt@gmail.com", true, false, null, null, "minhlt@gmail.com", "AQAAAAEAACcQAAAAEENaGqkUVu8lwv4l7GyqUksUrIy3UrP0jp0q+VVA8+eH4e3tsmRvaQmx34l9EAeERA==", null, false, "5a175391-0c22-40be-aa62-e207f9f63cc0", false, "cus_minh" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "1", "A" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "2", "S" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "3", "C" });

            migrationBuilder.CreateIndex(
                name: "IX_Books_CategoryId",
                table: "Books",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_RequestId",
                table: "Books",
                column: "RequestId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_BookId",
                table: "Orders",
                column: "BookId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "StoreOwners");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Requests");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "1", "A" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "2", "S" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "3", "C" });

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

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "A");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "C");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "S");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3");
        }
    }
}
