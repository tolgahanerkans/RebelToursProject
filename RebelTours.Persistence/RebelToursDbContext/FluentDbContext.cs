using Microsoft.EntityFrameworkCore;
using RebelTours.Domain;
using RebelTours.Persistence.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RebelTours.Persistence.RebelToursDbContext
{
    class FluentDbContext:DbContext
    {
        private const string ConnectionString = "Server=DESKTOP-MTU4EKB\\SQLEXPRESS; Database=RebelToursDb; Integrated Security=true;";

        public DbSet<City>Cities { get; set; }
        public DbSet<Station> Stations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.ApplyConfiguration(new CityConfigurations());
            modelBuilder.ApplyConfiguration(new StationConfigurations());
        }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}
