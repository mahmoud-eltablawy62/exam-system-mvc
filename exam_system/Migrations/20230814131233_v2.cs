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
                name: "FK_questions_instractors_ins_id",
                table: "questions");

            migrationBuilder.AlterColumn<int>(
                name: "ins_id",
                table: "questions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_questions_instractors_ins_id",
                table: "questions",
                column: "ins_id",
                principalTable: "instractors",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_questions_instractors_ins_id",
                table: "questions");

            migrationBuilder.AlterColumn<int>(
                name: "ins_id",
                table: "questions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_questions_instractors_ins_id",
                table: "questions",
                column: "ins_id",
                principalTable: "instractors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
