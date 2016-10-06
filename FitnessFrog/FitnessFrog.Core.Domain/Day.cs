using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessFrog.Core.Domain
{
    /// <summary>
    /// Defines all members of a FitnessFrog User's Day.
    /// </summary>
    public class Day
    {

        #region "private members"

        // None.

        #endregion


        #region "constructors"

        /// <summary>
        /// Default constructor for a User.
        /// </summary>
        public Day()
        {
            Initialize();
        }

        #endregion


        #region "public properties"

        /* NAVIGATION PROPERTIES */

        /// <summary>
        /// Gets the User identified by the UserId to which the Exercise belongs. This is
        /// for deep reference only. Assign UserId to change.
        /// </summary>
        public User User { get; set; }
        /// <summary>
        /// Gets or sets a collection of Exercises performed that Day.
        /// </summary>
        public ICollection<Exercise> Exercises { get; set; }
        /// <summary>
        /// Gets or sets a collection of Food eaten that Day.
        /// </summary>
        public ICollection<Food> Foods { get; set; }

        /* STANDARD PROPERTIES  */

        /// <summary>
        /// Gets or sets the Id of the Day.
        /// </summary>
        public int DayId { get; set; }
        /// <summary>
        /// Gets or sets the date and time of entry.
        /// </summary>
        public DateTime EntryDate { get; set; }
        /// <summary>
        /// Gets or sets the Id of the User.
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// Gets or sets the date and time the Day was created.
        /// </summary>
        public DateTime CreationDate { get; set; }
        /// <summary>
        /// Gets or sets the date and time the Day was last modified.
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
