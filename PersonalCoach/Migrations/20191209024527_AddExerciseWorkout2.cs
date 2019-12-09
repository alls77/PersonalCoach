using Microsoft.EntityFrameworkCore.Migrations;

namespace PersonalCoach.Migrations
{
    public partial class AddExerciseWorkout2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExerciseWorkoutDetails_ExerciseWorkout_ExerciseWorkoutExerciseId_ExerciseWorkoutWorkoutId",
                table: "ExerciseWorkoutDetails");

            migrationBuilder.DropIndex(
                name: "IX_ExerciseWorkoutDetails_ExerciseWorkoutExerciseId_ExerciseWorkoutWorkoutId",
                table: "ExerciseWorkoutDetails");

            migrationBuilder.DropColumn(
                name: "ExerciseWorkoutExerciseId",
                table: "ExerciseWorkoutDetails");

            migrationBuilder.DropColumn(
                name: "ExerciseWorkoutWorkoutId",
                table: "ExerciseWorkoutDetails");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ExerciseWorkoutExerciseId",
                table: "ExerciseWorkoutDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ExerciseWorkoutWorkoutId",
                table: "ExerciseWorkoutDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseWorkoutDetails_ExerciseWorkoutExerciseId_ExerciseWorkoutWorkoutId",
                table: "ExerciseWorkoutDetails",
                columns: new[] { "ExerciseWorkoutExerciseId", "ExerciseWorkoutWorkoutId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ExerciseWorkoutDetails_ExerciseWorkout_ExerciseWorkoutExerciseId_ExerciseWorkoutWorkoutId",
                table: "ExerciseWorkoutDetails",
                columns: new[] { "ExerciseWorkoutExerciseId", "ExerciseWorkoutWorkoutId" },
                principalTable: "ExerciseWorkout",
                principalColumns: new[] { "ExerciseId", "WorkoutId" },
                onDelete: ReferentialAction.Cascade);
        }
    }
}
