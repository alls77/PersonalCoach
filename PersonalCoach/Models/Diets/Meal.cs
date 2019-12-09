using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalCoach.Models.Diets
{
    public class Meal:BaseEntity
    {
        public int MealTypeId { get; set; }
        public MealType MealType { get; set; }
        public double proteins { get; set; }
        public double fats { get; set; }
        public double carbs { get; set; }
        public double calories { get; set; }
        public List<MealDish> MealDishes { get; set; }
        public List<DayRationMeal> DayRationMeals { get; set; }
    }
}
