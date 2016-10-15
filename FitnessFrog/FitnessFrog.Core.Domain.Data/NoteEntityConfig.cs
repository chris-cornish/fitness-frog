using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitnessFrog.Core.Domain.Data
{
    /// <summary>
    /// Provides configuration for Note CRUD operations.
    /// </summary>
    public class NoteEntityConfig : IEntityConfiguration
    {

        #region "private members"

        // None

        #endregion

        
        #region "constructors"

        /// <summary>
        /// Default constructor.
        /// </summary>
        /// <param name="entityBuilder">The entity being configured.</param>
        public NoteEntityConfig(EntityTypeBuilder<Note> entityBuilder)
        {
            this.Initialize(ref entityBuilder);
        }

        #endregion


        #region "public properties"

        /// <summary>
        /// Provides the table name.
        /// </summary>
        public string TableName { get { return "Notes"; } }
        /// <summary>
        /// Provides the type of the Entity configured.
        /// </summary>
        public Type EntityType { get { return typeof(Note); } }

        #endregion


        #region "private helper methods"

        private void Initialize(ref EntityTypeBuilder<Note> entityBuilder)
        {

            // Define the table name and schema apart from default conventions.
            entityBuilder.ToTable(TableName, "FitnessFrog");

            // Define primary key apart from default conventions.
            entityBuilder.HasKey(x => x.NoteId);

            // Define relationships and scope on appropriate key(s) apart from default conventions.
            entityBuilder.HasOne(o => o.User);

            // Define data column names and constraints map to properties apart from default conventions.

            entityBuilder.Property(a => a.NoteId)
                .HasColumnName("NoteId")
                .IsRequired();

            entityBuilder.Property(a => a.NoteDate)
                .HasColumnName("NoteDate")
                .HasDefaultValue(DateTime.Now);

            entityBuilder.Property(a => a.NoteText)
                .HasColumnName("NoteText")
                .HasMaxLength(4096)
                .IsRequired();

            entityBuilder.Property(a => a.NoteType)
                .HasColumnName("NoteType")
                .HasMaxLength(64)
                .IsRequired();

            entityBuilder.Property(a => a.NoteTypeId)
                .HasColumnName("NoteTypeId")
                .IsRequired();

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
