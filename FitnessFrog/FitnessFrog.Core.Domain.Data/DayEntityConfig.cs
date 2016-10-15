using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitnessFrog.Core.Domain.Data
{
    /// <summary>
    /// Provides configuration for Day CRUD operations.
    /// </summary>
    public class DayEntityConfig : IEntityConfiguration
    {

        #region "private members"

        // None

        #endregion


        #region "constructors"

        /// <summary>
        /// Default constructor.
        /// </summary>
        /// <param name="entityBuilder">The entity being configured.</param>
        public DayEntityConfig(EntityTypeBuilder<Day> entityBuilder)
        {
            this.Initialize(ref entityBuilder);
        }

        #endregion


        #region "public properties"

        /// <summary>
        /// Provides the table name.
        /// </summary>
        public string TableName { get { return "Days"; } }
        /// <summary>
        /// Provides the type of the Entity configured.
        /// </summary>
        public Type EntityType { get { return typeof(Day); } }

        #endregion


        #region "private helper methods"

        private void Initialize(ref EntityTypeBuilder<Day> entityBuilder)
        {

            // Define the table name and schema apart from the defualt conventions.
            entityBuilder.ToTable(TableName, "FitnessFrog");

            // Define primary key apart from defualt conventions.
            entityBuilder.HasKey(x => x.DayId);

            // Define relationships and scope on appropriate key(s) apart from default conventions.
            entityBuilder.HasOne(o => o.User);
            entityBuilder.HasMany(o => o.Exercises);
            entityBuilder.HasMany(o => o.Foods);

            // Define data column names and constraints map to properties apart from default conventions.

            entityBuilder.Property(a => a.DayId)
                .HasColumnName("DayId")
                .IsRequired();

            entityBuilder.Property(a => a.EntryDate)
                .HasColumnName("EntryDate")
                .HasDefaultValue(DateTime.Now);

            entityBuilder.Property(a => a.UserId)
                .HasColumnName("UserId")
                .IsRequired();

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
