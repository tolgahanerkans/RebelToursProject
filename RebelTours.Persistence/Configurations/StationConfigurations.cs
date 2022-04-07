using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RebelTours.Domain;

namespace RebelTours.Persistence.Configurations
{
    public class StationConfigurations : IEntityTypeConfiguration<Station>
    {
        public void Configure(EntityTypeBuilder<Station> builder)
        {
            builder.HasKey(stn => stn.Id);


            builder.Property(stn => stn.Name)
                
                .IsRequired()
                .HasColumnType("varchar(50)");
            builder.HasOne(cit => cit.City)
                .WithMany()
                .HasForeignKey(cit => cit.CityId);

            //SEED DATA
            builder.HasData(

                new Station() { Id = 1, Name = "Adana Terminali", CityId = 1 },
            new Station() { Id = 2, Name = "Aşti", CityId = 2, },
            new Station() { Id = 3, Name = "Harem", CityId = 4, },
            new Station() { Id = 4, Name = "Dudullu", CityId = 4, },
            new Station() { Id = 5, Name = "Esenler Otagarı", CityId = 4, },
            new Station() { Id = 6, Name = "Kaş Otogarı", CityId = 3, },
            new Station() { Id = 7, Name = "Fındık Terminali", CityId = 5, },
            new Station() { Id = 8, Name = "100.Yıl Terminalli", CityId = 6, }

                );





        }
    }
}
