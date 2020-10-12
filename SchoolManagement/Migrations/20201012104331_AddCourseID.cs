using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolManagement.Migrations
{
    public partial class AddCourseID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Courses_CoursesID",
                table: "Students");

            migrationBuilder.AlterColumn<int>(
                name: "CoursesID",
                table: "Students",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Courses_CoursesID",
                table: "Students",
                column: "CoursesID",
                principalTable: "Courses",
                principalColumn: "CoursesID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Courses_CoursesID",
                table: "Students");

            migrationBuilder.AlterColumn<int>(
                name: "CoursesID",
                table: "Students",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Courses_CoursesID",
                table: "Students",
                column: "CoursesID",
                principalTable: "Courses",
                principalColumn: "CoursesID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
