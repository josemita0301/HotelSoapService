using HotelSoapService.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelSoapService.Data
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<Availability> Availabilities { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
                
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Availability>()
                .ToTable("availability");

            modelBuilder.Entity<Availability>()
                .HasKey(r => r.availability_id); 
        }
    }
}
