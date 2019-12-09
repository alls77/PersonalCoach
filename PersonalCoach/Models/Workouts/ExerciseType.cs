using System.Collections.Generic;

namespace PersonalCoach.Models.Workouts
{
    public class ExerciseType : BaseNameEntity
    {
        public virtual List<Exercise> Exercises { get; set; }
    }
}
