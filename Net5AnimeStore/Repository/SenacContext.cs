using Microsoft.EntityFrameworkCore;
using Net5AnimeStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Net5AnimeStore.Repository
{
    public class SenacContext : DbContext
    {
        public DbSet<Models.Console> Consoles { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Figure> Figures { get; set; }

        public SenacContext(DbContextOptions<SenacContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ConsoleMapping());
            modelBuilder.ApplyConfiguration(new GameMapping());
            modelBuilder.ApplyConfiguration(new FigureMapping());

            base.OnModelCreating(modelBuilder);
        }

    }
}
