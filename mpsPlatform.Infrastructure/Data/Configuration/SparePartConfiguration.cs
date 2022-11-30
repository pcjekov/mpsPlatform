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
    internal class SparePartConfiguration : IEntityTypeConfiguration<SparePart>
    {
        public void Configure (EntityTypeBuilder<SparePart> builder)
        {
            builder.HasData(CreateSpareParts());
        }

        private List<SparePart> CreateSpareParts()
        {
            List<SparePart> spareParts = new List<SparePart>()
            {
                new SparePart()
                {
                    Id = 1,
                    Name = "cartridge",
                    PartNumber = "CF237YC",
                    Resource = 37000
                },
                new SparePart()
                {
                    Id = 2,
                    Name = "Maintenance Kit",
                    PartNumber = "L0H25A",
                    Resource = 225000
                },
                new SparePart()
                {
                    Id = 3,
                    Name = "black cartridge",
                    PartNumber = "006R01701",
                    Resource = 26000
                },
                new SparePart()
                {
                    Id = 4,
                    Name = "cyan cartridge",
                    PartNumber = "006R01702",
                    Resource = 15000
                },
                new SparePart()
                {
                    Id = 5,
                    Name = "magenta cartridge",
                    PartNumber = "006R01703",
                    Resource = 15000
                },
                new SparePart()
                {
                    Id = 6,
                    Name = "yellow cartridge",
                    PartNumber = "006R01704",
                    Resource = 15000
                },
                new SparePart()
                {
                    Id = 7,
                    Name = "drum",
                    PartNumber = "013R00662",
                    Resource = 126000
                },
                new SparePart()
                {
                    Id = 8,
                    Name = "black cartridge",
                    PartNumber = "006R01758",
                    Resource = 59000
                },
                new SparePart()
                {
                    Id = 9,
                    Name = "cyan cartridge",
                    PartNumber = "006R01759",
                    Resource = 28000
                },
                new SparePart()
                {
                    Id = 10,
                    Name = "magenta cartridge",
                    PartNumber = "006R01760",
                    Resource = 28000
                },
                new SparePart()
                {
                    Id = 11,
                    Name = "yellow cartridge",
                    PartNumber = "006R01761",
                    Resource = 28000
                },
                new SparePart()
                {
                    Id = 12,
                    Name = "drum",
                    PartNumber = "013R00681",
                    Resource = 180000
                },

                new SparePart()
                {
                    Id = 13,
                    Name = "cartridge",
                    PartNumber = "106R03585",
                    Resource = 37000
                },
                new SparePart()
                {
                    Id = 14,
                    Name = "drum",
                    PartNumber = "101R00554",
                    Resource = 24000
                }

            };


            return spareParts;
        }
    }
}
