using TripPlannerDAL.Entity;
using Microsoft.EntityFrameworkCore;

namespace TripPlannerDAL
{
    public class TripPlannerDbContext : DbContext
    {
        public DbSet<Activiteit> Activiteiten { get; set; }
        public DbSet<Continent> Continenten { get; set; }
        public DbSet<Entertainment> Entertainments { get; set; }
        public DbSet<Gebruiker> Gebruikers { get; set; }
        public DbSet<Land> Landen { get; set; }
        public DbSet<Plaats> Plaatsen { get; set; }
        public DbSet<Trip> Trips { get; set; }
        public DbSet<UserTrip> UserTrips { get; set; }
        public DbSet<Verblijf> Verblijven { get; set; }
        public DbSet<Verplaatsing> Verplaatsingen { get; set; }

        public TripPlannerDbContext(DbContextOptions<TripPlannerDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure relationships here
            modelBuilder.Entity<Activiteit>()
                .HasOne(a => a.plaats)
                .WithMany(p => p.activiteiten)
                .HasForeignKey(a => a.plaatsId);

            modelBuilder.Entity<Activiteit>()
                .HasOne(a => a.trip)
                .WithMany(t => t.activiteiten)
                .HasForeignKey(a => a.tripId);

            modelBuilder.Entity<Gebruiker>()
                .HasOne(g => g.plaats)
                .WithMany(p => p.gebruikers)
                .HasForeignKey(g => g.plaatsId);

            modelBuilder.Entity<Plaats>()
                .HasOne(p => p.land)
                .WithMany(l => l.plaatsen)
                .HasForeignKey(p => p.landId);

            modelBuilder.Entity<Land>()
                .HasOne(l => l.continent)
                .WithMany(c => c.Landen)
                .HasForeignKey(l => l.continentId);

            modelBuilder.Entity<Trip>()
                .HasMany(t => t.activiteiten)
                .WithOne(a => a.trip)
                .HasForeignKey(a => a.tripId);

            modelBuilder.Entity<UserTrip>()
                .HasOne(ut => ut.trip)
                .WithMany(t => t.userTrips)
                .HasForeignKey(ut => ut.Id);

            modelBuilder.Entity<UserTrip>()
                .HasOne(ut => ut.gebruiker)
                .WithMany(g => g.userTrips)
                .HasForeignKey(ut => ut.Id);

            // Set table names
            modelBuilder.Entity<Activiteit>().ToTable("Activiteit");
            modelBuilder.Entity<Continent>().ToTable("Continent");
            modelBuilder.Entity<Entertainment>().ToTable("Entertainment");
            modelBuilder.Entity<Gebruiker>().ToTable("Gebruiker");
            modelBuilder.Entity<Land>().ToTable("Land");
            modelBuilder.Entity<Plaats>().ToTable("Plaats");
            modelBuilder.Entity<Trip>().ToTable("Trip");
            modelBuilder.Entity<UserTrip>().ToTable("UserTrip");
            modelBuilder.Entity<Verblijf>().ToTable("Verblijf");
            modelBuilder.Entity<Verplaatsing>().ToTable("Verplaatsing");
        }
    }
}
