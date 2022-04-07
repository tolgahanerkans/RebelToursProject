using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RebelTours.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RebelTours.Persistence.Configurations
{
    class CityConfigurations : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasKey(cit => cit.Id);

            builder.Property(cit => cit.Name)
                .IsRequired()
                .HasColumnType("varchar(50)");


            builder.HasData(
               new City() { Id = 1, Name = "Adana", },
               new City() { Id = 2, Name = "Ankara" },
               new City() { Id = 3, Name = "Antalya" },
               new City() { Id = 4, Name = "İstanbul" },
               new City() { Id = 5, Name = "Ordu" },
               new City() { Id = 6, Name = "Zonguldak" }



               ) ;

        }
    }
}
