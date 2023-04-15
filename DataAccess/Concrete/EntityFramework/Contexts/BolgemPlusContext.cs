using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework.Contexts
{
    public class BolgemPlusContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-OIFQVQ4;Database=IscilikMaliyetDb;Trusted_Connection=true");
        }

        public DbSet<Job> Jobs { get; set; }
        public DbSet<Personel> Personels { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Shift> Shifts { get; set; }
        public DbSet<WorkingHour> WorkingHours { get; set; }
    }
}
