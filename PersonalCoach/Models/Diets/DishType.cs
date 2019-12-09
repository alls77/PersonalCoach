using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalCoach.Models.Diets
{
    public class DishType:BaseNameEntity
    {
        public List<Dish> Dishes { get; set; }
    }
}
