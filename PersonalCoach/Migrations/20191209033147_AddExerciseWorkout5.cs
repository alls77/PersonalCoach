using Microsoft.EntityFrameworkCore.Migrations;

namespace PersonalCoach.Migrations
{
    public partial class AddExerciseWorkout5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WorkoutFrequencies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkoutFrequencies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkoutPrograms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    WorkoutFrequencyId = table.Column<int>(nullable: false),
                    WorkoutTypeId = table.Column<int>(nullable: false),
                    DifficultyId = table.Column<int>(nullable: false),
                    WorkoutProgramTypeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkoutPrograms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkoutPrograms_Difficulties_DifficultyId",
                        column: x => x.DifficultyId,
                        principalTable: "Difficulties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkoutPrograms_WorkoutFrequencies_WorkoutFrequencyId",
                        column: x => x.WorkoutFrequencyId,
                        principalTable: "WorkoutFrequencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkoutPrograms_WorkoutProgramTypes_WorkoutProgramTypeId",
                        column: x => x.WorkoutProgramTypeId,
                        principalTable: "WorkoutProgramTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WorkoutPrograms_WorkoutTypes_WorkoutTypeId",
                        column: x => x.WorkoutTypeId,
                        principalTable: "WorkoutTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkoutProgramWorkout",
                columns: table => new
                {
                    WorkoutProgramId = table.Column<int>(nullable: false),
                    WorkoutId = table.Column<int>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Day = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkoutProgramWorkout", x => new { x.WorkoutProgramId, x.WorkoutId });
                    table.ForeignKey(
                        name: "FK_WorkoutProgramWorkout_Workouts_WorkoutId",
                        column: x => x.WorkoutId,
                        principalTable: "Workouts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkoutProgramWorkout_WorkoutPrograms_WorkoutProgramId",
                        column: x => x.WorkoutProgramId,
                        principalTable: "WorkoutPrograms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WorkoutFrequencies_Name",
                table: "WorkoutFrequencies",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WorkoutPrograms_DifficultyId",
                table: "WorkoutPrograms",
                column: "DifficultyId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkoutPrograms_WorkoutFrequencyId",
                table: "WorkoutPrograms",
                column: "WorkoutFrequencyId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkoutPrograms_WorkoutProgramTypeId",
                table: "WorkoutPrograms",
                column: "WorkoutProgramTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkoutPrograms_WorkoutTypeId",
                table: "WorkoutPrograms",
                column: "WorkoutTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkoutProgramWorkout_WorkoutId",
                table: "WorkoutProgramWorkout",
                column: "WorkoutId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WorkoutProgramWorkout");

            migrationBuilder.DropTable(
                name: "WorkoutPrograms");

            migrationBuilder.DropTable(
                name: "WorkoutFrequencies");
        }
    }
}
