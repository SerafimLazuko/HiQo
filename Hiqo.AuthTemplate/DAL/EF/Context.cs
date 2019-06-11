using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using DAL.Entities;

namespace DAL.EF
{
    public class Context : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        static Context()
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }

    
}
