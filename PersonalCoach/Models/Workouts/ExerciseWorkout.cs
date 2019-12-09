using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalCoach.Models.Workouts
{
    public class ExerciseWorkout:BaseEntity
    {
        public int ExerciseId { get; set; }
        public Exercise Exercise { get; set; }

        public int WorkoutId { get; set; }
        public Workout Workout { get; set; }

        public int Sets { get; set; }
        public int Repetitions { get; set; }
        public int Timer { get; set; }
    }
}
