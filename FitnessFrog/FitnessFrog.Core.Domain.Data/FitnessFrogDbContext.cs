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
