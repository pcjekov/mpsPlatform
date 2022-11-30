using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using mpsPlatform.Infrastructure.Data.Models;

namespace mpsPlatform.Infrastructure.Data.Configuration
{
    internal class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasData(CreateCustomers());
        }

       private List<Customer> CreateCustomers()
        {
            List<Customer> customers = new List<Customer>()
           {
               new Customer()
               {
                   Id = 1,
                   Name = "Metal Construct PLC"
               },
               new Customer()
               {
                   Id = 2,
                   Name = "Ring Ltd"
               }
           };

            return customers;
        }
    }
   
   
}
