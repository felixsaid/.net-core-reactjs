using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolManagement.Migrations
{
    public partial class ModifyModelKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Courses_CoursescourseId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_CoursescourseId",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Courses",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CoursescourseId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "courseId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "courseId",
                table: "Courses");

            migrationBuilder.RenameColumn(
                name: "studentId",
                table: "Students",
                newName: "StudentID");

            migrationBuilder.AddColumn<int>(
                name: "CoursesID",
                table: "Students",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CoursesID",
                table: "Courses",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Courses",
                table: "Courses",
                column: "CoursesID");

            migrationBuilder.CreateIndex(
                name: "IX_Students_CoursesID",
                table: "Students",
                column: "CoursesID");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Courses_CoursesID",
                table: "Students",
                column: "CoursesID",
                principalTable: "Courses",
                principalColumn: "CoursesID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Courses_CoursesID",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_CoursesID",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Courses",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CoursesID",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "CoursesID",
                table: "Courses");

            migrationBuilder.RenameColumn(
                name: "StudentID",
                table: "Students",
                newName: "studentId");

            migrationBuilder.AddColumn<int>(
                name: "CoursescourseId",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "courseId",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "courseId",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Courses",
                table: "Courses",
                column: "courseId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_CoursescourseId",
                table: "Students",
                column: "CoursescourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Courses_CoursescourseId",
                table: "Students",
                column: "CoursescourseId",
                principalTable: "Courses",
                principalColumn: "courseId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
