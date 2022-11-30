using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using mpsPlatform.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mpsPlatform.Infrastructure.Data.Configuration
{
    internal class LocationConfiguration : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder.HasData(CreateLocations());
        }

        private List<Location> CreateLocations()
        {
            List<Location> locations = new List<Location>()
            {
                new Location
                {
                    Id = 1,
                    EquimpentLocation = "Managers",
                    CustomerId = 2
                },

                new Location
                {
                    Id = 2,
                    EquimpentLocation = "PPR",
                    CustomerId = 2
                },

                new Location
                {
                    Id = 3,
                    EquimpentLocation = "Med.center",
                    CustomerId = 2
                },

                new Location
                {
                    Id = 4,
                    EquimpentLocation = "Capture",
                    CustomerId = 2
                },

                 new Location
                {
                    Id = 5,
                    EquimpentLocation = "Handwork",
                    CustomerId = 2
                },

                 new Location
                {
                    Id = 6,
                    EquimpentLocation = "Админ.сграда ет.1",
                    CustomerId = 1
                }

            };

            return locations;
        }
    }
}
