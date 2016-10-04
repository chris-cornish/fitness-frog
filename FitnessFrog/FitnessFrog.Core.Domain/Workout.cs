using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessFrog.Core.Domain
{
    public class Workout
    {
        public int WorkoutId { get; set; }

        public DateTime WorkoutDate { get; set; }

        public ICollection<Exercise> Exercises { get; set; }

        public Workout()
        {
            Exercises = new HashSet<Exercise>();
        }
    }
}
