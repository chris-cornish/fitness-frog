using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessFrog.Core.Domain
{
    public class Exercise
    {
        /// <summary>
        /// Gets or sets the Id of the Exercise.
        /// </summary>
        public int ExerciseId { get; set; }
        /// <summary>
        /// Gets or sets the name of the Exercise.
        /// </summary>
        public int Name { get; set; }
        /// <summary>
        /// Gets or sets the total sets of Exercise performed.
        /// </summary>
        public int Sets { get; set; }
        /// <summary>
        /// Gets or sets the total reps of Exercise performed.
        /// </summary>
        public int Reps { get; set; }
        /// <summary>
        /// Gets or sets the weight used for Exercise.
        /// </summary>
        public bool Weight { get; set; }
        /// <summary>
        /// Gets or sets the unit of weight used for Exercise.
        /// kg or lbs.
        /// </summary>
        public int Unit { get; set; }
        /// <summary>
        /// Gets or sets the Users notes of Exercise if needed.
        /// e.g. increase/decrease weight next time.
        /// </summary>
        public string Note { get; set; }
    }
}
