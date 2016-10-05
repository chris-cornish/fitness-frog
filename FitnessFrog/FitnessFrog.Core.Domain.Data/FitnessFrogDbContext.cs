using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FitnessFrog.Core.Domain.Data
{
    /// <summary>
    /// Database Context provider for FitnessFrog.
    /// </summary>
    public class FitnessFrogDbContext : DbContext
    {
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
        /// <summary>
        /// Collection of Users queryable with Linq.
        /// </summary>

        // TODO: Add the remaining DbSets for each model.

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Call base model contruction.
            base.OnModelCreating(modelBuilder);

            // Add the models with the Fluent API configurations defined.
            new UserEntityConfig(modelBuilder.Entity<User>());

            // TODO: Add the remaining configurations.
        }

    }
}
