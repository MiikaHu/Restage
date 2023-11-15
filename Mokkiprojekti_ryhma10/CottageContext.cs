using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mokkiprojekti_ryhma10
{
    internal class CottageContext : DbContext
    {
        public DbSet<Area> Areas { get; set; }
        public DbSet<Cottage> Cottages { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<ReservationService> ReservationServices { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Post> Posts { get; set; }


        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(
                "Data Source=c:\\temp\\cottage.db");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>()
                .HasKey(c => c.PostalCode);

            modelBuilder.Entity<ReservationService>()
        .HasKey(c => new { c.ReservationId, c.ServiceId });
        }

    }
}
