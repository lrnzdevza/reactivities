using System;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext 
    {
        public DataContext(DbContextOptions options) : base(options)
        {           
        }

        public DbSet<NewValue> Values { get; set; }
        public DbSet<Activity> Activities { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<NewValue>()
                    .HasData(
                        new NewValue{Id = 1, Name = "Value 101"},
                        new NewValue{Id = 2, Name = "Value 102"},
                        new NewValue{Id = 3, Name = "Value 103"}
                    );
        }
    }
}
