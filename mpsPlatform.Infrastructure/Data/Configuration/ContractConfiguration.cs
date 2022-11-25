using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using mpsPlatform.Infrastructure.Data.Models;

namespace mpsPlatform.Infrastructure.Data.Configuration
{
    internal class ContractConfiguration : IEntityTypeConfiguration<Contract>
    {
        public void Configure(EntityTypeBuilder<Contract> builder)
        {
            builder.HasData(CreateContracts());
        }

        private List<Contract> CreateContracts()
        {
            List<Contract> contracts = new List<Contract>()
            {
                new Contract()
                {
                    Id = 1,
                    ContractNumber = "CTR-003263/ 2022",
                    CustomerId = 2
                },

                new Contract()
                {
                    Id = 2,
                    ContractNumber = "CTR-004452/ 2021",
                    CustomerId = 1
                },

                new Contract()
                {
                    Id = 3,
                    ContractNumber = "CTR-002526/ 2019",
                    CustomerId = 2
                }
            };

            return contracts;
        }
    }
}
