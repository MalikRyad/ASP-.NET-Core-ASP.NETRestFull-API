using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance
{
    public class RepositoryDbContext :DbContext
    {
        public RepositoryDbContext(DbContextOptions options)
          : base(options)
        {
        }
         
        public DbSet<Platform> Platforms { get; set; }

        public DbSet<Command> Commands { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
           // modelBuilder.ApplyConfigurationsFromAssembly(typeof(RepositoryDbContext).Assembly);
        modelBuilder
               .Entity<Platform>()
                .HasMany(p => p.Command)
                .WithOne(p=> p.Platform)
                .HasForeignKey(p => p.PlatformId);

        modelBuilder
            .Entity<Command>()
                .HasOne(p => p.Platform)
                .WithMany(p => p.Command)
                .HasForeignKey(p =>p.PlatformId);
    }
}
}
   

