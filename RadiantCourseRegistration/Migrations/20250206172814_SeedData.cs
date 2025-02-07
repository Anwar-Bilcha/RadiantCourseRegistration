using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RadiantCourseRegistration.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "Description", "Duration", "Instructor", "Title", "UpdatedBy", "UpdatedOn" },
                values: new object[,]
                {
                    { 201, "Admin", new DateTime(2025, 2, 6, 20, 28, 14, 108, DateTimeKind.Local).AddTicks(4671), "Learn the fundamentals of ASP.NET Core.", "6 Weeks", "Anwar Bilcha", "ASP.NET Core Basics", "", new DateTime(2025, 2, 6, 20, 28, 14, 109, DateTimeKind.Local).AddTicks(1094) },
                    { 302, "Admin", new DateTime(2025, 2, 6, 20, 28, 14, 109, DateTimeKind.Local).AddTicks(1435), "Master EF Core for data access.", "4 Weeks", "Birhan Nega Smith", "Entity Framework Core", "", new DateTime(2025, 2, 6, 20, 28, 14, 109, DateTimeKind.Local).AddTicks(1437) },
                    { 403, "Admin", new DateTime(2025, 2, 6, 20, 28, 14, 109, DateTimeKind.Local).AddTicks(1439), "Build interactive web apps with Blazor.", "8 Weeks", "Kibru G.", "Blazor Web Development", "", new DateTime(2025, 2, 6, 20, 28, 14, 109, DateTimeKind.Local).AddTicks(1440) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 403);
        }
    }
}
