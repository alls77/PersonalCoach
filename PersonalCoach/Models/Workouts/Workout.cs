using System.Collections.Generic;

namespace PersonalCoach.Models.Workouts
{
    public class Workout: BaseNameEntity
    {
        public WorkoutType WorkoutType { get; set; }

        public List<ExerciseWorkout> ExerciseWorkouts { get; set; }

        public List<WorkoutProgramWorkout> WorkoutProgramWorkouts { get; set; }
    }
}
