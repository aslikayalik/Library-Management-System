using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations
{
    public partial class Edit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PageCount",
                table: "Books",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "StudentDetail",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 24, 14, 34, 22, 176, DateTimeKind.Local).AddTicks(8986));

            migrationBuilder.UpdateData(
                table: "StudentDetail",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 24, 14, 34, 22, 177, DateTimeKind.Local).AddTicks(2099));

            migrationBuilder.UpdateData(
                table: "StudentDetail",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 24, 14, 34, 22, 177, DateTimeKind.Local).AddTicks(2166));

            migrationBuilder.UpdateData(
                table: "StudentDetail",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 24, 14, 34, 22, 177, DateTimeKind.Local).AddTicks(2171));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 24, 14, 34, 22, 174, DateTimeKind.Local).AddTicks(4736));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 24, 14, 34, 22, 176, DateTimeKind.Local).AddTicks(2375));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 24, 14, 34, 22, 176, DateTimeKind.Local).AddTicks(2467));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 24, 14, 34, 22, 176, DateTimeKind.Local).AddTicks(2471));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2023, 4, 24, 14, 34, 22, 158, DateTimeKind.Local).AddTicks(55), "$2a$11$aKaES3dKWK.cizDK1BbhqejUF4k5mDir/AS6pnsQmiZcX6EcasltC" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2023, 4, 24, 14, 34, 22, 169, DateTimeKind.Local).AddTicks(5117), "$2a$11$TSxg1emZTx.77hCczrW36u6k1ixY1QtL.3m5m09hEv2Cd29JZSduK" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PageCount",
                table: "Books",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

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
                column: "CreatedDate",
                value: new DateTime(2023, 4, 16, 12, 56, 5, 216, DateTimeKind.Local).AddTicks(4898));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 16, 12, 56, 5, 216, DateTimeKind.Local).AddTicks(6551));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 16, 12, 56, 5, 216, DateTimeKind.Local).AddTicks(6604));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 16, 12, 56, 5, 216, DateTimeKind.Local).AddTicks(6609));

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
    }
}
