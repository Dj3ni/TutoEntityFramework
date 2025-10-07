using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TutoEntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class ChangeJoinTableName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Courses_CoursesId",
                table: "Enrollments");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Students_StudentsId",
                table: "Enrollments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Enrollments",
                table: "Enrollments");

            migrationBuilder.RenameTable(
                name: "Enrollments",
                newName: "StudentCourse");

            migrationBuilder.RenameIndex(
                name: "IX_Enrollments_StudentsId",
                table: "StudentCourse",
                newName: "IX_StudentCourse_StudentsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentCourse",
                table: "StudentCourse",
                columns: new[] { "CoursesId", "StudentsId" });

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCourse_Courses_CoursesId",
                table: "StudentCourse",
                column: "CoursesId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCourse_Students_StudentsId",
                table: "StudentCourse",
                column: "StudentsId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentCourse_Courses_CoursesId",
                table: "StudentCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentCourse_Students_StudentsId",
                table: "StudentCourse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentCourse",
                table: "StudentCourse");

            migrationBuilder.RenameTable(
                name: "StudentCourse",
                newName: "Enrollments");

            migrationBuilder.RenameIndex(
                name: "IX_StudentCourse_StudentsId",
                table: "Enrollments",
                newName: "IX_Enrollments_StudentsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Enrollments",
                table: "Enrollments",
                columns: new[] { "CoursesId", "StudentsId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Courses_CoursesId",
                table: "Enrollments",
                column: "CoursesId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Students_StudentsId",
                table: "Enrollments",
                column: "StudentsId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
