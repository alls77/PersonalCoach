using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalCoach.Models.Diets
{
    public class MealDish:BaseEntity
    {
        public int DishId { get; set; }
        public Dish Dish { get; set; }

        public int MealId { get; set; }
        public Meal Meal { get; set; }

        public double Quantity { get; set; }
    }
}
