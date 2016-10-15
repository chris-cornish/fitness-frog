using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessFrog.Core.Domain
{
    /// <summary>
    /// Defines all members of a FitnessFrog exercise.
    /// </summary>
    public class Exercise
    {

        #region "private members"

        // None.

        #endregion


        #region "constructors"

        /// <summary>
        /// Default constructor for an Exercise
        /// </summary>
        
        public Exercise()
        {
            Initialize();
        }

        #endregion


        #region "public properties"

        /* NAVIGATION PROPERTIES */

        /// <summary>
        /// Gets the Day identified by the DayId to which the Exercise belongs. This is
        /// for deep reference only. Assign DayId to change.
        /// </summary>
        public Day Day { get; set; }
        /// <summary>
        /// Gets the User identified by the UserId to which the Exercise belongs. This is
        /// for deep reference only. Assign UserId to change.
        /// </summary>
        public User User { get; set; }

        /* STANDARD PROPERTIES */

        /// <summary>
        /// Gets or sets the Id of Exercise.
        /// </summary>
        public int ExerciseId { get; set; }
        /// <summary>
        /// Gets or sets the Id of Day to which the Exercise belongs.
        /// </summary>
        public int DayId { get; set; }
        /// <summary>
        /// Gets or sets the Type of Exercise.
        /// </summary>
        public string ExerciseType { get; set; }
        /// <summary>
        /// Gets or sets the number of Sets performed for Exercise.
        /// </summary>
        public int Sets { get; set; }
        /// <summary>
        /// Gets or sets the number of Reps performed for Exercise.
        /// </summary>
        public int Reps { get; set; }
        /// <summary>
        /// Gets or sets the Weight used for Exercise.
        /// </summary>
        public int Weight { get; set; }
        /// <summary>
        /// Gets or sets the unit of weight used for Exercise.
        /// kg or lbs.
        /// </summary>
        public string UnitType { get; set; }
        /// <summary>
        /// Gets or sets the Id of the User.
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// Gets or sets the date and time the Exercise was created.
        /// </summary>
        public DateTime CreationDate { get; set; }
        /// <summary>
        /// Gets or sets the date and time the Exercise was last modified.
        /// </summary>
        public DateTime ModificationDate { get; set; }

        #endregion


        #region "public methods"

        // None

        #endregion


        #region "private helper methods"

        private void Initialize()
        {
            // Nothing to initialize.
        }

        #endregion

    }
}
