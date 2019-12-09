using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalCoach.Models.Workouts
{
    public class WorkoutProgram:BaseNameEntity
    {
        public int WorkoutFrequencyId { get; set; }
        public WorkoutFrequency WorkoutFrequency { get; set; }
        public int WorkoutProgramTypeId { get; set; }
        public WorkoutProgramType WorkoutProgramType { get; set; }
        public int DifficultyId { get; set; }
        public Difficulty Difficulty { get; set; }

        public List<WorkoutProgramWorkout> WorkoutProgramWorkouts { get; set; }


    }
}
