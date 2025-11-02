using Microsoft.EntityFrameworkCore;
using AirBB.Models;
using AirBB.Controllers;
using System;

namespace AirBB.Models
{
    public class AirBBContext : DbContext
    {
        public AirBBContext(DbContextOptions<AirBBContext> options)
            : base(options)
        {
        }

        public DbSet<Location> Locations { get; set; } = null!;
        public DbSet<Residence> Residences { get; set; } = null!;
        public DbSet<Reservation> Reservations { get; set; } = null!;

protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    base.OnModelCreating(modelBuilder);

    // --- Locations ---
    modelBuilder.Entity<Location>().HasData(
        new Location { LocationId = 1, Name = "Chicago" },
        new Location { LocationId = 2, Name = "New York" },
        new Location { LocationId = 3, Name = "Miami" },
        new Location { LocationId = 4, Name = "Atlanta" }
    );

    // --- Residences (2 per location = 8 total) ---
    modelBuilder.Entity<Residence>().HasData(
        // Chicago
        new
        {
            ResidenceId = 1,
            Name = "Chicago Loop Apartment",
            ResidencePicture = "chi1.jpg",
            LocationId = 1,
            GuestNumber = 4,
            BedroomNumber = 2,
            BathroomNumber = 2,
            PricePerNight = 180m
        },
        new
        {
            ResidenceId = 2,
            Name = "River North Condo",
            ResidencePicture = "chi2.jpg",
            LocationId = 1,
            GuestNumber = 2,
            BedroomNumber = 1,
            BathroomNumber = 1,
            PricePerNight = 140m
        },

        // New York
        new
        {
            ResidenceId = 3,
            Name = "Midtown Loft",
            ResidencePicture = "ny1.jpg",
            LocationId = 2,
            GuestNumber = 3,
            BedroomNumber = 1,
            BathroomNumber = 1,
            PricePerNight = 220m
        },
        new
        {
            ResidenceId = 4,
            Name = "Brooklyn Brownstone",
            ResidencePicture = "ny2.jpg",
            LocationId = 2,
            GuestNumber = 4,
            BedroomNumber = 2,
            BathroomNumber = 1,
            PricePerNight = 200m
        },

        // Miami
        new
        {
            ResidenceId = 5,
            Name = "Miami Beach House",
            ResidencePicture = "miami1.jpg",
            LocationId = 3,
            GuestNumber = 6,
            BedroomNumber = 3,
            BathroomNumber = 2,
            PricePerNight = 260m
        },
        new
        {
            ResidenceId = 6,
            Name = "South Beach Condo",
            ResidencePicture = "miami2.jpg",
            LocationId = 3,
            GuestNumber = 2,
            BedroomNumber = 1,
            BathroomNumber = 1,
            PricePerNight = 180m
        },

        // Atlanta
        new
        {
            ResidenceId = 7,
            Name = "Suburban Family Home",
            ResidencePicture = "atlanta1.jpg",
            LocationId = 4,
            GuestNumber = 5,
            BedroomNumber = 3,
            BathroomNumber = 2,
            PricePerNight = 190m
        },
        new
        {
            ResidenceId = 8,
            Name = "Downtown Apartment",
            ResidencePicture = "atlanta2.jpg",
            LocationId = 4,
            GuestNumber = 3,
            BedroomNumber = 2,
            BathroomNumber = 1,
            PricePerNight = 160m
        }
    );
}
    }
}   