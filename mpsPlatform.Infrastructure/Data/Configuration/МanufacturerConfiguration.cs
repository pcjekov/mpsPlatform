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
    internal class ManufacturerConfiguration : IEntityTypeConfiguration<Manufacturer>
    {
        public void Configure(EntityTypeBuilder<Manufacturer> builder)
        {
            builder.HasData(CreateManufacturers());
        }

        private List<Manufacturer> CreateManufacturers()
        {
            List<Manufacturer> manufacturers = new List<Manufacturer>()
            {
                new Manufacturer()
                {
                    Id = 1,
                    Name = "Xerox"
                },

                new Manufacturer()
                {
                    Id = 2,
                    Name = "HP"
                }
            };

            return manufacturers;
        }
    }
}
