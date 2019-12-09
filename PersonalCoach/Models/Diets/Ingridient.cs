using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalCoach.Models.Diets
{
    public class Ingridient: BaseNameEntity
    {
        public double proteins { get; set; }
        public double fats { get; set; }
        public double carbs { get; set; }
        public double calories { get; set; }
        public int IngridientTypeId { get; set; }
        public IngridientType IngridientType { get; set; }
        public List<DishIngridient> DishIngridients { get; set; }

    }
}
