using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessFrog.Core.Domain
{
    /// <summary>
    /// Defines all members of a FitnessFrog Note.
    /// </summary>
    public class Note
    {

        #region "private members"

        // None.

        #endregion


        #region "constructors"

        /// <summary>
        /// Default constructor for a Note.
        /// </summary>
        public Note()
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

        /* STANDARD PROPERTIES */

        /// <summary>
        /// Gets or sets the Id of the Note.
        /// </summary>
        public int NoteId { get; set; }
        /// <summary>
        /// Gets or sets the date and time of the Note.
        /// </summary>
        public DateTime NoteDate { get; set; }
        /// <summary>
        /// Gets or sets the text of the Note.
        /// </summary>
        public string NoteText { get; set; }
        /// <summary>
        /// Gets or sets the type of note (Food/Exercise).
        /// </summary>
        public string NoteType { get; set; }
        /// <summary>
        /// Gets or sets the Id related to NoteType (FoodId/ExerciseId).
        /// </summary>
        public string NoteTypeId { get; set; }
        /// <summary>
        /// Gets or sets the Id of the User.
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// Gets or sets the date and time the User was created.
        /// </summary>
        public DateTime CreationDate { get; set; }
        /// <summary>
        /// Gets or sets the date and time the User was last modified.
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
