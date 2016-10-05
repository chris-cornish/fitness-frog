using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitnessFrog.Core.Domain.Data
{
    /// <summary>
    /// Provides configuration for Food CRUD operations.
    /// </summary>
    public class FoodEntityConfig : IEntityConfiguration
    {

        #region "private members"

        // None

        #endregion


        #region "constructors"

        /// <summary>
        /// Default constructor.
        /// </summary>
        /// <param name="entityBuilder">The entity being configured.</param>
        public FoodEntityConfig(EntityTypeBuilder<Food> entityBuilder)
        {
            this.Initialize(ref entityBuilder);
        }

        #endregion


        #region "public properties"

        /// <summary>
        /// Provides the table name.
        /// </summary>
        public string TableName { get { return "Foods"; } }
        /// <summary>
        /// Provides the type of the Entity configured.
        /// </summary>
        public Type EntityType { get { return typeof(Food); } }

        #endregion


        #region "private helper methods"

        private void Initialize(ref EntityTypeBuilder<Food> entityBuilder)
        {

            // Define the table name and schema apart from default conventions.
            entityBuilder.ToTable(TableName, "FitnessFrog");

            // Define primary key apart from default conventions.
            entityBuilder.HasKey(x => x.UserId);

            // Define relationships and scope on appropriate key(s) apart from default conventions.
            entityBuilder.HasMany<Note>(o => o.Notes).WithOne().HasForeignKey(o => o.UserId);

            // Define data column names and constraints map to properties apart from default conventions.
            entityBuilder.Property(a => a.UserId)
                .HasColumnName("UserId")
                .IsRequired();

            entityBuilder.Property(a => a.FoodId)
                .HasColumnName("FoodId")
                .IsRequired();

            entityBuilder.Property(a => a.Name)
                .HasColumnName("Name")
                .HasMaxLength(64)
                .IsRequired();

            entityBuilder.Property(a => a.Fats)
                .HasColumnName("Fats");

            entityBuilder.Property(a => a.Carbs)
                .HasColumnName("Carbs");

            entityBuilder.Property(a => a.Proteins)
                .HasColumnName("Proteins");

            entityBuilder.Property(a => a.Calories)
                .HasColumnName("Calories");

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
