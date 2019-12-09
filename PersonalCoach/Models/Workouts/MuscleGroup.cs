using System.Collections.Generic;

namespace PersonalCoach.Models.Workouts
{
    public class MuscleGroup : BaseNameEntity
    {
        public virtual List<Exercise> Exercises { get; set; }
    }
}
