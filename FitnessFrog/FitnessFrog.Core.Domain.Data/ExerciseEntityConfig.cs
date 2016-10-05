using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitnessFrog.Core.Domain.Data
{
    /// <summary>
    /// Provides configuration for Exercise CRUD operations.
    /// </summary>
    public class ExerciseEntityConfig : IEntityConfiguration
    {

        #region "private members"

        // None

        #endregion


        #region "constructors"

        /// <summary>
        /// Default constructor.
        /// </summary>
        /// <param name="entityBuilder">The entity being configured.</param>
        public ExerciseEntityConfig(EntityTypeBuilder<Exercise> entityBuilder)
        {
            this.Initialize(ref entityBuilder);
        }

        #endregion

        #region "public properties"

        /// <summary>
        /// Provides the table name.
        /// </summary>
        public string TableName { get { return "Exercises"; } }
        /// <summary>
        /// Provides the type of the Entity configured.
        /// </summary>
        public Type EntityType { get { return typeof(Exercise); } }

        #endregion


        #region "private helper methods"
        #endregion

    }
}
