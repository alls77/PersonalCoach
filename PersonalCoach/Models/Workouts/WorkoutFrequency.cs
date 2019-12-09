using System.Collections.Generic;

namespace PersonalCoach.Models.Workouts
{
    public class WorkoutFrequency:BaseNameEntity
    {
        public virtual List<WorkoutProgram> WorkoutPrograms { get; set; }
    }
}
