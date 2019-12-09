using Microsoft.EntityFrameworkCore.Migrations;

namespace PersonalCoach.Migrations
{
    public partial class AddExerciseWorkout6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkoutPrograms_WorkoutProgramTypes_WorkoutProgramTypeId",
                table: "WorkoutPrograms");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkoutPrograms_WorkoutTypes_WorkoutTypeId",
                table: "WorkoutPrograms");

            migrationBuilder.DropIndex(
                name: "IX_WorkoutPrograms_WorkoutTypeId",
                table: "WorkoutPrograms");

            migrationBuilder.DropColumn(
                name: "WorkoutTypeId",
                table: "WorkoutPrograms");

            migrationBuilder.AlterColumn<int>(
                name: "WorkoutProgramTypeId",
                table: "WorkoutPrograms",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkoutPrograms_WorkoutProgramTypes_WorkoutProgramTypeId",
                table: "WorkoutPrograms",
                column: "WorkoutProgramTypeId",
                principalTable: "WorkoutProgramTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkoutPrograms_WorkoutProgramTypes_WorkoutProgramTypeId",
                table: "WorkoutPrograms");

            migrationBuilder.AlterColumn<int>(
                name: "WorkoutProgramTypeId",
                table: "WorkoutPrograms",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "WorkoutTypeId",
                table: "WorkoutPrograms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_WorkoutPrograms_WorkoutTypeId",
                table: "WorkoutPrograms",
                column: "WorkoutTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkoutPrograms_WorkoutProgramTypes_WorkoutProgramTypeId",
                table: "WorkoutPrograms",
                column: "WorkoutProgramTypeId",
                principalTable: "WorkoutProgramTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkoutPrograms_WorkoutTypes_WorkoutTypeId",
                table: "WorkoutPrograms",
                column: "WorkoutTypeId",
                principalTable: "WorkoutTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
