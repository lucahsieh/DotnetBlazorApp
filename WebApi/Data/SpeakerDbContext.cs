using System;
using Microsoft.EntityFrameworkCore;
using WebApi.Models;

namespace WebApi.Data
{
    public class SpeakerDbContext : DbContext
    {
        public DbSet<Speaker> speakers { get; set; }
        public SpeakerDbContext(DbContextOptions<SpeakerDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Speaker>().HasData(
                new
                {
                    speakerId = Guid.NewGuid().ToString(),
                    firstName = "Jim",
                    lastName = "Potter",
                    email = "jim@potter.ca",
                    mobileNumber = "604-123-4567",
                    areaOfSpecialization = "Cloud Architect",
                    cityOfResidence = "Chillwack",
                    provinceOfResidence = "BC",
                    employer = "BC Hydro"
                }
            );
        }
    }
}