using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalCoach.Models.Diets
{
    public class DishIngridient : BaseEntity
    {
        public int DishId { get; set; }
        public Dish Dish { get; set; }

        public int IngridientId { get; set; }
        public Ingridient Ingridient { get; set; }

        public double Quantity { get; set; }
    }
}
