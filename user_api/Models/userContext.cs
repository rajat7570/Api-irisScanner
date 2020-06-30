using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using user_api.Entities;

namespace user_api.Models
{
    public class userContext : DbContext
    {
        public userContext(DbContextOptions<userContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Employees>().HasIndex(u => u.iris).IsUnique();
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Employees> Employees { get; set; }
    }
}
