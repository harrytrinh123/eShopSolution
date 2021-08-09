using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class ChangeProductImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cation",
                table: "ProductImages");

            migrationBuilder.AddColumn<string>(
                name: "Caption",
                table: "ProductImages",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<long>(
                name: "FileSize",
                table: "ProductImages",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ce0a502b-bb31-478e-b559-3cc9b535e1af"),
                column: "ConcurrencyStamp",
                value: "9493fdd7-0cdd-41a5-bc58-043eb30e339e");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cb1ff856-4278-4c44-8aad-5b7af26b7279", "AQAAAAEAACcQAAAAEElOfvclmPqpg0azsy4ib6oin59LHNSzTNTsFeNSEaeU9buRpoWeGOit02pFhTWcmA==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 8, 9, 22, 55, 1, 196, DateTimeKind.Local).AddTicks(8124));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Caption",
                table: "ProductImages");

            migrationBuilder.DropColumn(
                name: "FileSize",
                table: "ProductImages");

            migrationBuilder.AddColumn<string>(
                name: "Cation",
                table: "ProductImages",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ce0a502b-bb31-478e-b559-3cc9b535e1af"),
                column: "ConcurrencyStamp",
                value: "80f9b6ec-f0cc-4677-ae4a-785f4446795d");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e3bace29-9533-45ad-a9fa-23b1cb10d7ae", "AQAAAAEAACcQAAAAEDvLR2B0SDm2z3/Sj/SXkLtQzuKUbAVCEVQMB1mVYgaX04CLTsXcjCryWn+gdVAOqg==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 8, 7, 11, 6, 37, 201, DateTimeKind.Local).AddTicks(2224));
        }
    }
}
