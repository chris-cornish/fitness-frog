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

        private void Initialize(ref EntityTypeBuilder<Exercise> entityBuilder)
        {
            
            // Define primary key apart from default conventions.
            entityBuilder.HasKey(x => x.UserId);

            // Define relationships and scope on appropriate key(s) apart from default conventions.
            entityBuilder.HasMany<Note>(o => o.Notes).WithOne().HasForeignKey(o => o.UserId);

            // Define data column names and constraints map to properties apart from default conventions.
            entityBuilder.Property(a => a.UserId)
                .HasColumnName("UserId")
                .IsRequired();

            entityBuilder.Property(a => a.ExerciseId)
                .HasColumnName("ExerciseId")
                .IsRequired();

            entityBuilder.Property(a => a.ExerciseType)
                .HasColumnName("ExerciseType")
                .IsRequired();

            entityBuilder.Property(a => a.Sets)
                .HasColumnName("Sets")
                .IsRequired();

            entityBuilder.Property(a => a.Reps)
                .HasColumnName("Reps")
                .IsRequired();

            entityBuilder.Property(a => a.Weight)
                .HasColumnName("Weight");

            entityBuilder.Property(a => a.UnitType)
                .HasColumnName("UnitType");

            entityBuilder.Property(a => a.CreationDate)
                .HasColumnName("CreationDate")
                .HasDefaultValue(DateTime.Now);

            entityBuilder.Property(a => a.ModificationDate)
                .HasColumnName("ModificationDate")
                .HasDefaultValue(DateTime.Now);

        }

        #endregion

    }
}
