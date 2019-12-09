using System.Collections.Generic;

namespace PersonalCoach.Models.Workouts
{
    public class WorkoutType: BaseNameEntity
    {
        public virtual List<Workout> Workouts { get; set; }
    }
}
