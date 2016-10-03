using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessFrog.Core
{
    public class Food
    {
        public int FoodId { get; set; }

        public string Name { get; set; }

        public int Fats { get; set; }

        public int Carbs { get; set; }

        public int Proteins { get; set; }

        public int Calories { get; set; }
        /// <summary>
        /// Gets or sets the Users notes of Food if needed.
        /// e.g. liked/disliked the food.
        /// </summary>
        public string Note { get; set; }
    }
}
