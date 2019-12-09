using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalCoach.Models.Workouts
{
    public class WorkoutProgramWorkout:BaseEntity
    {
        public int WorkoutProgramId { get; set; }
        public WorkoutProgram WorkoutProgram { get; set; }

        public int WorkoutId { get; set; }
        public Workout Workout { get; set; }

        public String Day { get; set; }
    }
}
