using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitnessFrog.Core.Domain.Data
{
    /// <summary>
    /// Provides configuration for User CRUD operations.
    /// </summary>
    public class UserEntityConfig : IEntityConfiguration
    {

        #region "private members"

        // None

        #endregion


        #region "constructors"

        /// <summary>
        /// Default constructor.
        /// </summary>
        /// <param name="entityBuilder">The entity being configured.</param>
        public UserEntityConfig(EntityTypeBuilder<User> entityBuilder)
        {
            this.Initialize(ref entityBuilder);
        }

        public UserEntityConfig(EntityTypeBuilder<Day> entityBuilder)
        {
            this.Initialize(ref entityBuilder);
        }

        public UserEntityConfig(EntityTypeBuilder<Exercise> entityBuilder)
        {
            this.Initialize(ref entityBuilder);
        }

        public UserEntityConfig(EntityTypeBuilder<Food> entityBuilder)
        {
            this.Initialize(ref entityBuilder);
        }

        public UserEntityConfig(EntityTypeBuilder<Note> entityBuilder)
        {
            this.Initialize(ref entityBuilder);
        }

        #endregion


        #region "public properties"

        /// <summary>
        /// Provides the table name.
        /// </summary>
        public string TableName { get { return "Users"; } }
        /// <summary>
        /// Provides the type of the Entity configured.
        /// </summary>
        public Type EntityType { get { return typeof(User); } }

        #endregion


        #region "private helper methods"

        private void Initialize(ref EntityTypeBuilder<User> entityBuilder)
        {

            // EntityFramework will assume table names, schema, column names, and constraints
            // at the database level with default behaviors and its own conventions. EF is, at
            // the end of the day, an ORM, mapping database tables to domain objects. As such,
            // we may want to configure the mapping behavior with more control. Likewise, in
            // a code-first implemenation, an initial migration will create the database and
            // it would be nice to really define, right down to column lenghts, what you want
            // it to look like. The Fluent API lets us do this.  EntityFrameworkCore has not 
            // fully matured here yet, but seems to be far enough along to enforce the concept, 
            // though in a slightly different way than in EF6. This is especially useful for 
            // defining how object collections get loaded, etc.  Likewise, applying constraints 
            // using the Fluent API is more elegant than decorator attributes on domain models.
            // It keeps database stuff separated from the business class concerns.

            // Define the table name and schema apart from default conventions.
            entityBuilder.ToTable(TableName, "FitnessFrog");

            // Define primary key apart from default conventions.
            entityBuilder.HasKey(x => x.UserId);

            // Define relationships and scope on appropriate key(s) apart from default conventions.
            entityBuilder.HasMany<Day>(o => o.Days).WithOne().HasForeignKey(o => o.UserId);
            entityBuilder.HasMany<Note>(o => o.Notes).WithOne().HasForeignKey(o => o.UserId);

            // Define data column names and constraints map to properties apart from default conventions.
            entityBuilder.Property(a => a.UserId)
                .HasColumnName("UserId")
                .IsRequired();

            entityBuilder.Property(a => a.Name)
                .HasColumnName("Name")
                .HasMaxLength(64)
                .IsRequired();

            entityBuilder.Property(a => a.EmailAddress)
                .HasColumnName("EmailAddress")
                .HasMaxLength(128)
                .IsRequired();

            entityBuilder.Property(a => a.Password)
                .HasColumnName("Password")
                .HasMaxLength(256)
                .IsRequired();

            entityBuilder.Property(a => a.PasswordRecoveryQuestion)
                .HasColumnName("PasswordRecoveryQuestion")
                .HasMaxLength(128);

            entityBuilder.Property(a => a.PasswordRecoveryAnswer)
                .HasColumnName("PasswordRecoveryAnswer")
                .HasMaxLength(64);

            entityBuilder.Property(a => a.CreationDate)
                .HasColumnName("CreationDate")
                .HasDefaultValue(DateTime.Now);

            entityBuilder.Property(a => a.ModificationDate)
                .HasColumnName("ModificationDate")
                .HasDefaultValue(DateTime.Now);

            entityBuilder.Property(a => a.LastLoginDate)
                .HasColumnName("LastLoginDate")
                .HasDefaultValue(DateTime.Now);

            entityBuilder.Property(a => a.LastLoginIp)
                .HasColumnName("LastLoginIp")
                .HasMaxLength(32);

            entityBuilder.Property(a => a.Enabled)
                .HasColumnName("Enabled");

        }
        private void Initialize(ref EntityTypeBuilder<Day> entityBuilder)
        {
            throw new NotImplementedException();
        }
        private void Initialize(ref EntityTypeBuilder<Exercise> entityBuilder)
        {
            throw new NotImplementedException();
        }
        private void Initialize(ref EntityTypeBuilder<Food> entityBuilder)
        {
            throw new NotImplementedException();
        }
        private void Initialize(ref EntityTypeBuilder<Note> entityBuilder)
        {
            throw new NotImplementedException();
        }

        #endregion

    }
}
