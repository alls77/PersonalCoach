using System.Collections.Generic;

namespace PersonalCoach.Models.Workouts
{
    public class Equipment : BaseNameEntity
    {
        public virtual List<Exercise> Exercises { get; set; }
    }
}
