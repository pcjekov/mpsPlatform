using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using mpsPlatform.Infrastructure.Data.Models;
using mpsPlatform.Infrastructure.Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mpsPlatform.Infrastructure.Data.Configuration
{
    internal class ЕquipmentModelConfiguration : IEntityTypeConfiguration<ЕquipmentModel>
    {
        public void Configure(EntityTypeBuilder<ЕquipmentModel> builder)
        {
            builder.HasData(CreateЕquipmentModels());
        }

        private List<ЕquipmentModel> CreateЕquipmentModels()
        {
            List<ЕquipmentModel> equipmentModels = new List<ЕquipmentModel>()
            {
                new ЕquipmentModel
                {
                    Id = 1,
                    Name = "VersaLink B610dn",
                    PartNumber = "B610V_DN",
                    MaxPaperType = MaxPaperType.A4,
                    EquimpentType = EquipmentType.BW,
                    МanifacturerId = 1,
                },
                new ЕquipmentModel
                {
                    Id = 2,
                    Name = "VersaLink B405",
                    PartNumber = "B405V_DN",
                    MaxPaperType = MaxPaperType.A4,
                    EquimpentType = EquipmentType.BW,
                    МanifacturerId = 1,
                },
                new ЕquipmentModel
                {
                    Id = 3,
                    Name = "AltaLink C8035",
                    PartNumber = "C8001V_T_097S04830",
                    MaxPaperType = MaxPaperType.A3,
                    EquimpentType = EquipmentType.Col,
                    МanifacturerId = 1,
                },
                new ЕquipmentModel
                {
                    Id = 4,
                    Name = "AltaLink C8155",
                    PartNumber = "C8102V_F_097S05045",
                    MaxPaperType = MaxPaperType.A3,
                    EquimpentType = EquipmentType.Col,
                    МanifacturerId = 1,
                },

                new ЕquipmentModel
                {
                    Id = 5,
                    Name = "LaserJet M609dn",
                    PartNumber = "K0Q21A",
                    MaxPaperType = MaxPaperType.A4,
                    EquimpentType = EquipmentType.BW,
                    МanifacturerId = 2,
                },

                new ЕquipmentModel
                {
                    Id = 6,
                    Name = "VersaLink B605",
                    PartNumber = "B605V_DN",
                    MaxPaperType = MaxPaperType.A4,
                    EquimpentType = EquipmentType.BW,
                    МanifacturerId = 1,
                }
            };

            return equipmentModels;
        }
    }
}
