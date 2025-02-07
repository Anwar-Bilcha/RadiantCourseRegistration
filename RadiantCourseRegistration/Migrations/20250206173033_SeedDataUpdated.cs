using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RadiantCourseRegistration.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 2, 6, 20, 28, 14, 108, DateTimeKind.Local).AddTicks(4671), new DateTime(2025, 2, 6, 20, 28, 14, 109, DateTimeKind.Local).AddTicks(1094) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 2, 6, 20, 28, 14, 109, DateTimeKind.Local).AddTicks(1435), new DateTime(2025, 2, 6, 20, 28, 14, 109, DateTimeKind.Local).AddTicks(1437) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 2, 6, 20, 28, 14, 109, DateTimeKind.Local).AddTicks(1439), new DateTime(2025, 2, 6, 20, 28, 14, 109, DateTimeKind.Local).AddTicks(1440) });
        }
    }
}
