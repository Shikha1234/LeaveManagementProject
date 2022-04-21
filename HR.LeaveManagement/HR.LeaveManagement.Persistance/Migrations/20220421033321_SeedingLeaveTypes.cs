using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HR.LeaveManagement.Persistance.Migrations
{
    public partial class SeedingLeaveTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "LeaveTypes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DefaultDays", "LastModifiedBy", "LastModifiedDate", "Name" },
                values: new object[] { 1, "SP", new DateTime(2022, 4, 21, 9, 3, 21, 207, DateTimeKind.Local).AddTicks(5850), 10, "Sp", new DateTime(2022, 4, 21, 9, 3, 21, 207, DateTimeKind.Local).AddTicks(5863), "Vacation" });

            migrationBuilder.InsertData(
                table: "LeaveTypes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DefaultDays", "LastModifiedBy", "LastModifiedDate", "Name" },
                values: new object[] { 2, "SP1", new DateTime(2022, 4, 21, 9, 3, 21, 207, DateTimeKind.Local).AddTicks(5867), 12, "Sp1", new DateTime(2022, 4, 21, 9, 3, 21, 207, DateTimeKind.Local).AddTicks(5867), "Sick" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
