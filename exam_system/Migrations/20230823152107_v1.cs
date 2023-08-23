using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace exam_system.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "instractors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_instractors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "questions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    head = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    body = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    answer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    answer_stud = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ins_id = table.Column<int>(type: "int", nullable: true),
                    exam_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_questions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_questions_exams_exam_id",
                        column: x => x.exam_id,
                        principalTable: "exams",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_questions_instractors_ins_id",
                        column: x => x.ins_id,
                        principalTable: "instractors",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    grade = table.Column<int>(type: "int", nullable: false),
                    ins_id = table.Column<int>(type: "int", nullable: true),
                    choice = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_students_instractors_ins_id",
                        column: x => x.ins_id,
                        principalTable: "instractors",
                        principalColumn: "Id");
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
                name: "IX_exam_Students_Stu_Id",
                table: "exam_Students",
                column: "Stu_Id");

            migrationBuilder.CreateIndex(
                name: "IX_instractors_Email",
                table: "instractors",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_questions_exam_id",
                table: "questions",
                column: "exam_id");

            migrationBuilder.CreateIndex(
                name: "IX_questions_ins_id",
                table: "questions",
                column: "ins_id");

            migrationBuilder.CreateIndex(
                name: "IX_students_email",
                table: "students",
                column: "email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_students_ins_id",
                table: "students",
                column: "ins_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "exam_Students");

            migrationBuilder.DropTable(
                name: "questions");

            migrationBuilder.DropTable(
                name: "students");

            migrationBuilder.DropTable(
                name: "exams");

            migrationBuilder.DropTable(
                name: "instractors");
        }
    }
}
