using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace exam_system.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_questions_exams_exam_id",
                table: "questions");

            migrationBuilder.DropTable(
                name: "exam_Students");

            migrationBuilder.DropTable(
                name: "exams");

            migrationBuilder.DropIndex(
                name: "IX_questions_exam_id",
                table: "questions");

            migrationBuilder.DropColumn(
                name: "exam_id",
                table: "questions");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "exam_id",
                table: "questions",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "exams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_exams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "exam_Students",
                columns: table => new
                {
                    Ex_Id = table.Column<int>(type: "int", nullable: false),
                    Stu_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_exam_Students", x => new { x.Ex_Id, x.Stu_Id });
                    table.ForeignKey(
                        name: "FK_exam_Students_exams_Ex_Id",
                        column: x => x.Ex_Id,
                        principalTable: "exams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_exam_Students_students_Stu_Id",
                        column: x => x.Stu_Id,
                        principalTable: "students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_questions_exam_id",
                table: "questions",
                column: "exam_id");

            migrationBuilder.CreateIndex(
                name: "IX_exam_Students_Stu_Id",
                table: "exam_Students",
                column: "Stu_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_questions_exams_exam_id",
                table: "questions",
                column: "exam_id",
                principalTable: "exams",
                principalColumn: "Id");
        }
    }
}
