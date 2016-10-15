using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

namespace FitnessFrog.Core.Domain.Data
{
    /// <summary>
    /// Database Context provider for FitnessFrog.
    /// </summary>
    public class FitnessFrogDbContext : DbContext
    {
        #region "constructors"

        public FitnessFrogDbContext()
            : base()
        {
            this.Database.Migrate();
        }

        public FitnessFrogDbContext(DbContextOptions options)
            : base(options)
        {
            this.Database.Migrate();
        }

        public FitnessFrogDbContext(DbContextOptions options, bool migrate)
            : base(options)
        {
            if (migrate)
            {
                this.Database.Migrate();
            }
        }

        #endregion

        #region "dbsets"

        /// <summary>
        /// Collection of Users queryable with Linq.
        /// </summary>
        public DbSet<User> Users { get; set; }
        /// <summary>
        /// Collection of Days queryable with Linq.
        /// </summary>
        public DbSet<Day> Days { get; set; }
        /// <summary>
        /// Collection of Exercises queryable with Linq.
        /// </summary>
        public DbSet<Exercise> Exercises { get; set; }
        /// <summary>
        /// Collection of Foods queryable with Linq.
        /// </summary>
        public DbSet<Food> Foods { get; set; }
        /// <summary>
        /// Collection of Notes queryable with Linq.
        /// </summary>
        public DbSet<Note> Notes { get; set; }

        #endregion


        #region "protected overrides"

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Call base model contruction.
            base.OnModelCreating(modelBuilder);

            // Add the models with the Fluent API configurations defined.
            new UserEntityConfig(modelBuilder.Entity<User>());
            new DayEntityConfig(modelBuilder.Entity<Day>());
            new ExerciseEntityConfig(modelBuilder.Entity<Exercise>());
            new FoodEntityConfig(modelBuilder.Entity<Food>());
            new NoteEntityConfig(modelBuilder.Entity<Note>());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        #endregion

    }
}
