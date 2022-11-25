using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using mpsPlatform.Infrastructure.Data.Models;

namespace mpsPlatform.Infrastructure.Data.Configuration
{
    internal class SerialNumberConfiguration : IEntityTypeConfiguration<SerialNumber>
    {
        public void Configure(EntityTypeBuilder<SerialNumber> builder)
        {
            builder.HasData(CreateSerialNumbers());
        }

        private List<SerialNumber> CreateSerialNumbers()
        {
            List<SerialNumber> serialNumbers = new List<SerialNumber>()
            {
                new SerialNumber()
                {
                    Id = 1,
                    ЕquipmentSerialNumber = "3717622919",
                    ЕquipmentModelId = 3,
                    LocationId = 1,
                    ContractId = 1,
                    PriceMonochromeA4 = 0.00108m,
                    PriceMonochromeA3 = 0.00216m,
                    PriceColorA4 = 0.0818m,
                    PriceColorA3 = 0.1722m

                },

                new SerialNumber()
                {
                    Id = 2,
                    ЕquipmentSerialNumber = "3774403743",
                    ЕquipmentModelId = 4,
                    LocationId = 2,
                    ContractId = 1,
                    PriceMonochromeA4 = 0.00108m,
                    PriceMonochromeA3 = 0.00216m,
                    PriceColorA4 = 0.0818m,
                    PriceColorA3 = 0.1722m

                },

                new SerialNumber()
                {
                    Id = 3,
                    ЕquipmentSerialNumber = "3719467309",
                    ЕquipmentModelId = 2,
                    LocationId = 3,
                    ContractId = 1,
                    PriceMonochromeA4 = 0.0189m,
                },

                new SerialNumber()
                {
                    Id = 4,
                    ЕquipmentSerialNumber = "CNBVK9317X",
                    ЕquipmentModelId = 5,
                    LocationId = 4,
                    ContractId = 3,
                    PriceMonochromeA4 = 0.02m,
                },

                new SerialNumber()
                {
                    Id = 5,
                    ЕquipmentSerialNumber = "3394734267",
                    ЕquipmentModelId = 1,
                    LocationId = 6,
                    ContractId = 3,
                    PriceMonochromeA4 = 0.02m,
                },

                new SerialNumber()
                {
                    Id = 6,
                    ЕquipmentSerialNumber = "3394976619",
                    ЕquipmentModelId = 6,
                    LocationId = 6,
                    ContractId = 2,
                    PriceMonochromeA4 = 0.018m,
                }
            };

            return serialNumbers;
        }
    }
}
