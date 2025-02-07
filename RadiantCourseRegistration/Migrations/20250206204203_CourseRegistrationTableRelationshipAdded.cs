using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RadiantCourseRegistration.Migrations
{
    /// <inheritdoc />
    public partial class CourseRegistrationTableRelationshipAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseRegistrations_Courses_CourseId1",
                table: "CourseRegistrations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Courses",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_CourseRegistrations_CourseId1",
                table: "CourseRegistrations");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 403);

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CourseId1",
                table: "CourseRegistrations");

            migrationBuilder.AddColumn<string>(
                name: "CourseId",
                table: "Courses",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Courses",
                table: "Courses",
                column: "CourseId");

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CreatedBy", "CreatedOn", "Description", "Duration", "Instructor", "Title", "UpdatedBy", "UpdatedOn" },
                values: new object[,]
                {
                    { "201", "Admin", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Learn the fundamentals of ASP.NET Core.", "6 Weeks", "Anwar Bilcha", "ASP.NET Core Basics", "", null },
                    { "302", "Admin", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Master EF Core for data access.", "4 Weeks", "Birhan Nega Smith", "Entity Framework Core", "", null },
                    { "403", "Admin", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Build interactive web apps with Blazor.", "8 Weeks", "Kibru G.", "Blazor Web Development", "", null }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_CourseRegistrations_Courses_CourseId",
                table: "CourseRegistrations",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseRegistrations_Courses_CourseId",
                table: "CourseRegistrations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Courses",
                table: "Courses");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyColumnType: "nvarchar(450)",
                keyValue: "201");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyColumnType: "nvarchar(450)",
                keyValue: "302");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyColumnType: "nvarchar(450)",
                keyValue: "403");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Courses");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "CourseId1",
                table: "CourseRegistrations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Courses",
                table: "Courses",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "Description", "Duration", "Instructor", "Title", "UpdatedBy", "UpdatedOn" },
                values: new object[,]
                {
                    { 201, "Admin", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Learn the fundamentals of ASP.NET Core.", "6 Weeks", "Anwar Bilcha", "ASP.NET Core Basics", "", null },
                    { 302, "Admin", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Master EF Core for data access.", "4 Weeks", "Birhan Nega Smith", "Entity Framework Core", "", null },
                    { 403, "Admin", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Build interactive web apps with Blazor.", "8 Weeks", "Kibru G.", "Blazor Web Development", "", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseRegistrations_CourseId1",
                table: "CourseRegistrations",
                column: "CourseId1");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseRegistrations_Courses_CourseId1",
                table: "CourseRegistrations",
                column: "CourseId1",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
