using System.Collections.Generic;
using System.Reflection.Emit;
using System.Security.Claims;
using System.Security;
using Microsoft.EntityFrameworkCore;
using Praktikum.Repository.entities;
using Praktikum.Repository;

namespace Praktikum.DBContext
{
    public class MyDBContext:DbContext,IContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Child> Children { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=(localDb)\msSQlLocalDb;database=PraktikumMG;Trusted_Connection=True");
        }
        protected override void OnModelCreating(ModelBuilder modelbulider)
        {
            base.OnModelCreating(modelbulider);

        }
    }
}