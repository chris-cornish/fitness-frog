using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessFrog.Core.Domain
{
    /// <summary>
    /// Defines all members of a FitnessFrog Food.
    /// </summary>
    public class Food
    {

        #region "private member"

        // None.

        #endregion

        #region "constructors"

        /// <summary>
        /// Default constructor for Food.
        /// </summary>
        public Food()
        {
            Initialize();
        }

        #endregion

        #region "public methods"

        /// <summary>
        /// Gets or sets the Id of the Food.
        /// </summary>
        public int FoodId { get; set; }
        /// <summary>
        /// Gets or sets the Name of the Food.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the number of Fats of the Food.
        /// </summary>
        public int Fats { get; set; }
        /// <summary>
        /// Gets or sets the number of Carbs of the Food.
        /// </summary>
        public int Carbs { get; set; }
        /// <summary>
        /// Gets or sets the number of Proteins of the Food.
        /// </summary>
        public int Proteins { get; set; }
        /// <summary>
        /// Gets or sets the number of Calories of the Food.
        /// </summary>
        public int Calories { get; set; }
        /// <summary>
        /// Gets or sets collection of Food Notes.
        /// </summary>
        public ICollection<Note> Notes { get; set; }
        /// <summary>
        /// Gets or sets the Id of the Food.
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// Gets or sets the date and time the Food was created.
        /// </summary>
        public DateTime CreationDate { get; set; }
        /// <summary>
        /// Gets or sets the date and time the Food was last modified.
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
