using System;
using System.Collections.Generic;

namespace PersonalCoach.Models.Workouts
{
    public class Exercise : BaseNameEntity
    {
        public int ExerciseTypeId { get; set; }
        public virtual ExerciseType ExerciseType { get; set; }
        public int EquipmentId { get; set; }
        public virtual Equipment Equipment { get; set; }
        public int MuscleGroupId { get; set; }
        public virtual MuscleGroup MuscleGroup { get; set; }
        public String Description { get; set; }
        public List<ExerciseWorkout> ExerciseWorkouts { get; set; }
    }
}
