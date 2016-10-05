using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessFrog.Core.Domain
{
    /// <summary>
    /// Defines all members of a FitnessFrog User.
    /// </summary>
    public class User
    {

        #region "private members"

        // None.

        #endregion


        #region "constructors"

        /// <summary>
        /// Default constructor for a User.
        /// </summary>
        public User()
        {
            this.Initialize();
        }

        #endregion


        #region "public properties"

        /// <summary>
        /// Gets or sets the Id of the User.
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// Gets or sets the Name of the User as he/she would like it to appear.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the Email Address of the User, which is also used as the
        /// username for authentication.
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// Gets or sets the 1-way hash representation of the password the User provides for
        /// authentication.
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// Gets or sets the question the User chooses to provide an answer for when he/she
        /// has forgotten the Password.
        /// </summary>
        public string PasswordRecoveryQuestion { get; set; }
        /// <summary>
        /// Gets or sets the 1-way hash representation of the answer the User provides to the
        /// PasswordRecoveryQuestion when he/she has forgotten the Password.
        /// </summary>
        public string PasswordRecoveryAnswer { get; set; }
        /// <summary>
        /// Gets or sets the date and time the User was created.
        /// </summary>
        public DateTime CreationDate { get; set; }
        /// <summary>
        /// Gets or sets the date and time the User was last modified.
        /// </summary>
        public DateTime ModificationDate { get; set;  }
        /// <summary>
        /// Gets or sets the date and time the User last logged into a FitnessFrog interface.
        /// </summary>
        public DateTime LastLoginDate { get; set; }
        /// <summary>
        /// Gets or sets the IP address from where the User last logged into FitnessFrog.
        /// </summary>
        public string LastLoginIp { get; set; }
        /// <summary>
        /// Gets or sets whether or not the User is enabled and can log in.
        /// </summary>
        public bool Enabled { get; set; }
        /// <summary>
        /// Gets or sets a collection of days tracked by the User.
        /// </summary>
        public ICollection<Day> Days { get; set; }
        /// <summary>
        /// Gets or sets a collection of notes added by the User across foods and exercises.
        /// </summary>
        public ICollection<Note> Notes { get; set; }

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
