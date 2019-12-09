using System;
using System.Collections.Generic;

namespace PersonalCoach.Models.Workouts
{
    public class WorkoutProgramType : BaseNameEntity
    {
        public List<WorkoutProgram> WorkoutPrograms { get; set; }
    }
}
