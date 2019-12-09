using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalCoach.Models.Diets
{
    public class DayRationMeal:BaseEntity
    {
        public int DayRationId { get; set; }
        public DayRation DayRation { get; set; }

        public int MealId { get; set; }
        public Meal Meal { get; set; }
    }
}
