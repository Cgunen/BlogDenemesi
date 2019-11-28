using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.Data.Migrations
{
    public partial class Seed_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2019, 11, 28, 17, 56, 47, 817, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2019, 11, 28, 17, 56, 47, 818, DateTimeKind.Utc));

            migrationBuilder.InsertData(
                table: "Nationality",
                columns: new[] { "Id", "Code", "CreateDate", "Deleted", "Name" },
                values: new object[] { 1, "tr", new DateTime(2019, 11, 28, 17, 56, 47, 818, DateTimeKind.Utc), false, "Türkiye" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BirthDate", "CreateDate", "Deleted", "Email", "Gender", "Name", "NationalityId", "Password", "Surname", "Username" },
                values: new object[] { 1, new DateTime(1991, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 11, 28, 17, 56, 47, 818, DateTimeKind.Utc), false, "caglar@caglar.com", 1, "Caglar", 1, "123456789", "Caglar", "caglar" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Nationality",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2019, 11, 28, 17, 40, 42, 864, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2019, 11, 28, 17, 40, 42, 865, DateTimeKind.Utc));

        }
    }
}
