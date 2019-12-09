using System.Collections.Generic;

namespace PersonalCoach.Models.Workouts
{
    public class Difficulty: BaseNameEntity
    {
        public virtual List<WorkoutProgram> WorkoutPrograms { get; set; }
    }
}
