using Microsoft.EntityFrameworkCore;
using serwis_z_filmami.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace serwis_z_filmami.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aktor_Film>().HasKey(am => new
            {
                am.aktorId,
                am.filmId
            });

            modelBuilder.Entity<Aktor_Film>().HasOne(m => m.Film).WithMany(am => am.Aktorzy_Filmy).HasForeignKey(m => m.filmId);

            modelBuilder.Entity<Aktor_Film>().HasOne(m => m.Aktor).WithMany(am => am.Aktorzy_Filmy).HasForeignKey(m => m.aktorId);

            base.OnModelCreating(modelBuilder);
        }

        //tabele ogólne
        public DbSet<Aktor> Aktorzy { get; set; }
        public DbSet<Film> Filmy{ get; set; }
        public DbSet<Aktor_Film> Aktorzy_Filmy { get; set; }
        public DbSet<Producent> Producent { get; set; }
        public DbSet<Kino> Kino { get; set; }
    }
}
