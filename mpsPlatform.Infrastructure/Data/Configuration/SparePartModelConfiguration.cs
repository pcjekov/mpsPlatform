using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using mpsPlatform.Infrastructure.Data.Models;

namespace mpsPlatform.Infrastructure.Data.Configuration
{
    internal class SparePartModelConfiguration : IEntityTypeConfiguration<SparePartModel>
    {
        public void Configure(EntityTypeBuilder<SparePartModel> builder)
        {
            builder.HasData(CreateSparePartModels());
        }

        private List<SparePartModel> CreateSparePartModels()
        {
            List<SparePartModel> sparePartModels = new List<SparePartModel>()
            {
                new SparePartModel()
                {
                    SparePartId = 1,
                    ЕquipmentModelId = 5
                },

                new SparePartModel()
                {
                    SparePartId = 2,
                    ЕquipmentModelId = 5
                },

                new SparePartModel()
                {
                    SparePartId = 3,
                    ЕquipmentModelId = 3
                },

                new SparePartModel()
                {
                    SparePartId = 4,
                    ЕquipmentModelId = 3
                },

                new SparePartModel()
                {
                    SparePartId = 5,
                    ЕquipmentModelId = 3
                },

                new SparePartModel()
                {
                    SparePartId = 6,
                    ЕquipmentModelId = 3
                },

                new SparePartModel()
                {
                    SparePartId = 7,
                    ЕquipmentModelId = 3
                },

                new SparePartModel()
                {
                    SparePartId = 8,
                    ЕquipmentModelId = 4
                },

                new SparePartModel()
                {
                    SparePartId = 9,
                    ЕquipmentModelId = 4
                },

                new SparePartModel()
                {
                    SparePartId = 10,
                    ЕquipmentModelId = 4
                },

                new SparePartModel()
                {
                    SparePartId = 11,
                    ЕquipmentModelId = 4
                },

                new SparePartModel()
                {
                    SparePartId = 12,
                    ЕquipmentModelId = 4
                },

                new SparePartModel()
                {
                    SparePartId = 13,
                    ЕquipmentModelId = 2
                },

                new SparePartModel()
                {
                    SparePartId = 14,
                    ЕquipmentModelId = 2
                }
            };

            return sparePartModels;
        }
    }
}