using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalCoach.Models.Diets
{
    public class IngridientType:BaseNameEntity
    {
        public List<Ingridient> Ingridients { get; set; }
    }
}
