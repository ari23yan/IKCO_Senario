using Microsoft.EntityFrameworkCore;
using Senario01.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senario01.Data.Context
{
    public class Senario01DbContext : DbContext
    {
        public Senario01DbContext(DbContextOptions<Senario01DbContext> options): base(options) { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<City> Cities { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Customer>(entity =>
        //    {
        //        entity.HasOne(d => d.City)
        //            .WithMany(p => p.Customers)
        //            .HasForeignKey(d => d.CityId);
        //    });

        //    modelBuilder.Entity<City>(entity =>
        //    {
        //        entity.Property(e => e.Id)
        //            .HasColumnName("CityId");
        //        entity.HasMany(d => d.Customers)
        //            .WithOne(p => p.City)
        //            .HasForeignKey(d => d.CityId);
        //    });
        //}
    }
}
