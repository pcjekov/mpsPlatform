using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using mpsPlatform.Infrastructure.Data.Models;

namespace mpsPlatform.Infrastructure.Data.Configuration
{
    internal class CounterColorA3Configuration : IEntityTypeConfiguration<CounterColorA3>
    {
        public void Configure(EntityTypeBuilder<CounterColorA3> builder)
        {
            builder.HasData(CreateCounterColorA3());
        }

        private List<CounterColorA3> CreateCounterColorA3()
        {
            List<CounterColorA3> counters = new List<CounterColorA3>()
            {
                new CounterColorA3()
                {
                    Id = 1,
                    CurrentCounter = 4670,
                    SerialNumberId = 1,
                    DateOfEntryId = 1,
                },

                new CounterColorA3()
                {
                    Id = 2,
                    CurrentCounter = 390,
                    SerialNumberId = 2,
                    DateOfEntryId = 1,
                }

            };

            return counters;
        }
    }
}
