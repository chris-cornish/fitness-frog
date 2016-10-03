using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessFrog.Core
{
    public class FoodLog
    {
        public int FoodLogId { get; set; }
        public DateTime FoodLogDate { get; set; }
        public ICollection<Food> Foods { get; set; }
        public FoodLog()
        {
            Foods = new HashSet<Food>();
        }
    }
}
