using Microsoft.EntityFrameworkCore.Migrations;

namespace PersonalCoach.Migrations
{
    public partial class AddExerciseWorkout : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Workouts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    WorkoutTypeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workouts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Workouts_WorkoutTypes_WorkoutTypeId",
                        column: x => x.WorkoutTypeId,
                        principalTable: "WorkoutTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ExerciseWorkout",
                columns: table => new
                {
                    ExerciseId = table.Column<int>(nullable: false),
                    WorkoutId = table.Column<int>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseWorkout", x => new { x.ExerciseId, x.WorkoutId });
                    table.ForeignKey(
                        name: "FK_ExerciseWorkout_Exercises_ExerciseId",
                        column: x => x.ExerciseId,
                        principalTable: "Exercises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExerciseWorkout_Workouts_WorkoutId",
                        column: x => x.WorkoutId,
                        principalTable: "Workouts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExerciseWorkoutDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExerciseWorkoutId = table.Column<int>(nullable: false),
                    ExerciseWorkoutExerciseId = table.Column<int>(nullable: false),
                    ExerciseWorkoutWorkoutId = table.Column<int>(nullable: false),
                    Sets = table.Column<int>(nullable: false),
                    Repetitions = table.Column<int>(nullable: false),
                    Timer = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseWorkoutDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExerciseWorkoutDetails_ExerciseWorkout_ExerciseWorkoutExerciseId_ExerciseWorkoutWorkoutId",
                        columns: x => new { x.ExerciseWorkoutExerciseId, x.ExerciseWorkoutWorkoutId },
                        principalTable: "ExerciseWorkout",
                        principalColumns: new[] { "ExerciseId", "WorkoutId" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseWorkout_WorkoutId",
                table: "ExerciseWorkout",
                column: "WorkoutId");

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseWorkoutDetails_ExerciseWorkoutExerciseId_ExerciseWorkoutWorkoutId",
                table: "ExerciseWorkoutDetails",
                columns: new[] { "ExerciseWorkoutExerciseId", "ExerciseWorkoutWorkoutId" });

            migrationBuilder.CreateIndex(
                name: "IX_Workouts_WorkoutTypeId",
                table: "Workouts",
                column: "WorkoutTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropTable(
                name: "ExerciseWorkoutDetails");

            migrationBuilder.DropTable(
                name: "ExerciseWorkout");

            migrationBuilder.DropTable(
                name: "Workouts");
        }
    }
}
