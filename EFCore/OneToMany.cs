using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore
{
    internal class OneToMany
    {
        public class Country
        {
            public int Id { get; set; }

            public string ?Name { get; set; }

            public ICollection<City> ?City { get; set; }
        }

        public class City
        {
            public int Id { get; set; }

            public string ?Name { get; set; }

            public int FKCountry { get; set; }

            public Country ?Country { get; set; }
        }

        public class CompanyContext : DbContext
        {
            public DbSet<City> ?City { get; set; }
            public DbSet<Country> ?Country { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-JIFTFVO\UGURGUR;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                }
            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                //Write Fluent API configurations here

                modelBuilder.Entity<City>()
                            .HasOne(e => e.Country)
                            .WithMany(e => e.City)
                            .HasForeignKey(e => e.FKCountry)
                            .OnDelete(DeleteBehavior.Cascade); ;
            }
        }
    }
}
