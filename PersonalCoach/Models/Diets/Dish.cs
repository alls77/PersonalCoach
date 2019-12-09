using System;
using System.Collections.Generic;

namespace PersonalCoach.Models.Diets
{
    public class Dish:BaseNameEntity
    {
        public double proteins { get; set; }
        public double fats { get; set; }
        public double carbs { get; set; }
        public double calories { get; set; }
        public String description { get; set; }
        public int DishTypeId { get; set; }
        public DishType DishType { get; set; }
        public List<DishIngridient> DishIngridients { get; set; }
        public List<MealDish> MealDishes { get; set; }
    } 
}
