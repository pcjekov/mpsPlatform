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
    internal class МanifacturerConfiguration : IEntityTypeConfiguration<Мanifacturer>
    {
        public void Configure(EntityTypeBuilder<Мanifacturer> builder)
        {
            builder.HasData(CreateМanifacturers());
        }

        private List<Мanifacturer> CreateМanifacturers()
        {
            List<Мanifacturer> manifacturers = new List<Мanifacturer>()
            {
                new Мanifacturer()
                {
                    Id = 1,
                    Name = "Xerox"
                },

                new Мanifacturer()
                {
                    Id = 2,
                    Name = "HP"
                }
            };

            return manifacturers;
        }
    }
}
