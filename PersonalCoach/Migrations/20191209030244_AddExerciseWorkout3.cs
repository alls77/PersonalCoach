using Microsoft.EntityFrameworkCore.Migrations;

namespace PersonalCoach.Migrations
{
    public partial class AddExerciseWorkout3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExerciseWorkoutDetails");

            migrationBuilder.AddColumn<int>(
                name: "Repetitions",
                table: "ExerciseWorkout",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Sets",
                table: "ExerciseWorkout",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Timer",
                table: "ExerciseWorkout",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Repetitions",
                table: "ExerciseWorkout");

            migrationBuilder.DropColumn(
                name: "Sets",
                table: "ExerciseWorkout");

            migrationBuilder.DropColumn(
                name: "Timer",
                table: "ExerciseWorkout");

            migrationBuilder.CreateTable(
                name: "ExerciseWorkoutDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExerciseWorkoutId = table.Column<int>(type: "int", nullable: false),
                    Repetitions = table.Column<int>(type: "int", nullable: false),
                    Sets = table.Column<int>(type: "int", nullable: false),
                    Timer = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseWorkoutDetails", x => x.Id);
                });
        }
    }
}
