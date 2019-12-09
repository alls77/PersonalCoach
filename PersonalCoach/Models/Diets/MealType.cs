using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalCoach.Models.Diets
{
    public class MealType:BaseNameEntity
    {
        public List<Meal> Meals { get; set; }
    }
}
