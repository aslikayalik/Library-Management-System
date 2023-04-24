using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations
{
    public partial class AddSeedDataUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "StudentDetail",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 16, 12, 56, 5, 216, DateTimeKind.Local).AddTicks(7808));

            migrationBuilder.UpdateData(
                table: "StudentDetail",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 16, 12, 56, 5, 216, DateTimeKind.Local).AddTicks(9964));

            migrationBuilder.UpdateData(
                table: "StudentDetail",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 16, 12, 56, 5, 217, DateTimeKind.Local).AddTicks(26));

            migrationBuilder.UpdateData(
                table: "StudentDetail",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 16, 12, 56, 5, 217, DateTimeKind.Local).AddTicks(31));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "FirstName", "LastName" },
                values: new object[] { new DateTime(2023, 4, 16, 12, 56, 5, 216, DateTimeKind.Local).AddTicks(4898), "Avacato", "Great" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "FirstName", "LastName" },
                values: new object[] { new DateTime(2023, 4, 16, 12, 56, 5, 216, DateTimeKind.Local).AddTicks(6551), "Mooncake", "Green" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "FirstName", "LastName" },
                values: new object[] { new DateTime(2023, 4, 16, 12, 56, 5, 216, DateTimeKind.Local).AddTicks(6604), "Gary", "GoodSpeed" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "FirstName", "LastName" },
                values: new object[] { new DateTime(2023, 4, 16, 12, 56, 5, 216, DateTimeKind.Local).AddTicks(6609), "Tribore", "Menendez" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2023, 4, 16, 12, 56, 5, 209, DateTimeKind.Local).AddTicks(3081), "$2a$11$qgoZKieJdal2rgIUCtsoXuT7hCCu55Z38N7mCz.43ZVp/tz573JmK" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2023, 4, 16, 12, 56, 5, 214, DateTimeKind.Local).AddTicks(1400), "$2a$11$QfAbWGg.cc5uArZHa3Bt3OWnvQXbgcWF8Kt.FwswFQBF.fTVK7vnm" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "StudentDetail",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 16, 12, 47, 7, 799, DateTimeKind.Local).AddTicks(4633));

            migrationBuilder.UpdateData(
                table: "StudentDetail",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 16, 12, 47, 7, 799, DateTimeKind.Local).AddTicks(5924));

            migrationBuilder.UpdateData(
                table: "StudentDetail",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 16, 12, 47, 7, 799, DateTimeKind.Local).AddTicks(5971));

            migrationBuilder.UpdateData(
                table: "StudentDetail",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 16, 12, 47, 7, 799, DateTimeKind.Local).AddTicks(5978));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "FirstName", "LastName" },
                values: new object[] { new DateTime(2023, 4, 16, 12, 47, 7, 799, DateTimeKind.Local).AddTicks(1065), "", "" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "FirstName", "LastName" },
                values: new object[] { new DateTime(2023, 4, 16, 12, 47, 7, 799, DateTimeKind.Local).AddTicks(3299), "", "" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "FirstName", "LastName" },
                values: new object[] { new DateTime(2023, 4, 16, 12, 47, 7, 799, DateTimeKind.Local).AddTicks(3349), "", "" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "FirstName", "LastName" },
                values: new object[] { new DateTime(2023, 4, 16, 12, 47, 7, 799, DateTimeKind.Local).AddTicks(3353), "", "" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2023, 4, 16, 12, 47, 7, 791, DateTimeKind.Local).AddTicks(7279), "$2a$11$J4tdke2LYWtjxRyr/bEw9ulYZ6mUTuEIpaE02fot5q6Ut/kDGh54y" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2023, 4, 16, 12, 47, 7, 797, DateTimeKind.Local).AddTicks(1196), "$2a$11$07L9Qlfv/Q.11UJYzigCduG1S2De4gHOJ3CzziO0pJ2S.x5xgbrIW" });
        }
    }
}
