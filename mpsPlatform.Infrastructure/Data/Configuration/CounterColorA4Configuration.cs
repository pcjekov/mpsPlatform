using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using mpsPlatform.Infrastructure.Data.Models;

namespace mpsPlatform.Infrastructure.Data.Configuration
{
    internal class CounterColorA4Configuration : IEntityTypeConfiguration<CounterColorA4>
    {
        public void Configure(EntityTypeBuilder<CounterColorA4> builder)
        {
            builder.HasData(CreateCounterColorA4());
        }

        private List<CounterColorA4> CreateCounterColorA4()
        {
            List<CounterColorA4> counters = new List<CounterColorA4>()
            {
                new CounterColorA4()
                {
                    Id = 1,
                    CurrentCounter = 336300,
                    SerialNumberId = 1,
                    DateOfEntryId = 1,
                },

                new CounterColorA4()
                {
                    Id = 2,
                    CurrentCounter = 35800,
                    SerialNumberId = 2,
                    DateOfEntryId = 1,
                }

            };

            return counters;
        }
    }
}
