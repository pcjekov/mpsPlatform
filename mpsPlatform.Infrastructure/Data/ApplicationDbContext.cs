using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using mpsPlatform.Infrastructure.Data.Configuration;
using mpsPlatform.Infrastructure.Data.Models;

namespace mpsPlatform.Infrastructure.Data
{
    public class ApplicationDbContext:IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<CounterColorA3> CountersColorA3 { get; set; } = null!;
        public DbSet<CounterColorA4> CountersColorA4 { get; set; } = null!;
        public DbSet<CounterMonochromeA3> CountersMonochromeA3 { get; set; } = null!;
        public DbSet<CounterMonochromeA4> CountersMonochromeA4 { get; set; } = null!;
        public DbSet<Customer> Customers { get; set; } = null!;
        public DbSet<DateOfEntry> DatesOfEntrys { get; set; } = null!;
        public DbSet<EquimpentSerialNumber> EquimpentSerialNumbers { get; set; } = null!;
        public DbSet<InstallerMan> InstallersPeople { get; set; } = null!;
        public DbSet<ЕquipmentLocation> ЕquipmentLocations { get; set; } = null!;
        public DbSet<ЕquipmentModel> ЕquipmentModels { get; set; } = null!;
        public DbSet<SparePart> SpareParts { get; set; } = null!;
        public DbSet<SparePartModel> SparePartsModels { get; set; } = null!;
        public DbSet<Мanifacturer> Мanifacturers { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SparePartModel>()
                .HasKey(sm => new
                {
                    sm.SparePartId,
                    sm.ЕquipmentModelId

                });


            modelBuilder.Entity<EquimpentSerialNumber>(entity =>
            {
                entity.HasOne(e => e.ЕquipmentLocation)
                    .WithMany(e => e.EquimpentSerialNumbers)
                    .HasForeignKey(d => d.ЕquipmentLocationId)
                    .OnDelete(DeleteBehavior.ClientCascade);

                entity.HasOne(e => e.ЕquipmentModel)
                    .WithMany(e => e.EquimpentSerialNumbers)
                    .HasForeignKey(d => d.ЕquipmentModelId)
                    .OnDelete(DeleteBehavior.ClientCascade);
            });
                       

            modelBuilder.ApplyConfiguration(new UserConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
