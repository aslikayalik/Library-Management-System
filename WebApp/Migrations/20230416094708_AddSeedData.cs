using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations
{
    public partial class AddSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "ID", "CreatedDate", "FirstName", "Gender", "LastName", "ModifiedDate", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 16, 12, 47, 7, 799, DateTimeKind.Local).AddTicks(1065), "", 0, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 2, new DateTime(2023, 4, 16, 12, 47, 7, 799, DateTimeKind.Local).AddTicks(3299), "", 0, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 3, new DateTime(2023, 4, 16, 12, 47, 7, 799, DateTimeKind.Local).AddTicks(3349), "", 0, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 4, new DateTime(2023, 4, 16, 12, 47, 7, 799, DateTimeKind.Local).AddTicks(3353), "", 1, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "CreatedDate", "ModifiedDate", "Password", "Role", "Status", "UserName" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 16, 12, 47, 7, 791, DateTimeKind.Local).AddTicks(7279), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "$2a$11$J4tdke2LYWtjxRyr/bEw9ulYZ6mUTuEIpaE02fot5q6Ut/kDGh54y", 1, 0, "administrator" },
                    { 2, new DateTime(2023, 4, 16, 12, 47, 7, 797, DateTimeKind.Local).AddTicks(1196), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "$2a$11$07L9Qlfv/Q.11UJYzigCduG1S2De4gHOJ3CzziO0pJ2S.x5xgbrIW", 2, 0, "Aslı" }
                });

            migrationBuilder.InsertData(
                table: "StudentDetail",
                columns: new[] { "ID", "BirthDay", "CreatedDate", "ModifiedDate", "PhoneNumber", "SchoolNumber", "Status", "StudentID" },
                values: new object[,]
                {
                    { 1, new DateTime(1987, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 16, 12, 47, 7, 799, DateTimeKind.Local).AddTicks(4633), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "70", 0, 1 },
                    { 2, new DateTime(1989, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 16, 12, 47, 7, 799, DateTimeKind.Local).AddTicks(5924), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "85", 0, 2 },
                    { 3, new DateTime(1986, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 16, 12, 47, 7, 799, DateTimeKind.Local).AddTicks(5971), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "196", 0, 3 },
                    { 4, new DateTime(1986, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 16, 12, 47, 7, 799, DateTimeKind.Local).AddTicks(5978), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "317", 0, 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentDetail",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "StudentDetail",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "StudentDetail",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "StudentDetail",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 4);
        }
    }
}
