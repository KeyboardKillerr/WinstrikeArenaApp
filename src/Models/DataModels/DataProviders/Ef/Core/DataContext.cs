using DataModels.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataModels.DataProviders.Ef.Core
{
    public class DataContext : DbContext
    {
        public DbSet<Application> Applications { get; set; } = null!;
        public DbSet<Computer> Computers { get; set; } = null!;
        public DbSet<Game> Games { get; set; } = null!;
        public DbSet<Genre> Genres { get; set; } = null!;
        public DbSet<LoginLog> LoginLogs { get; set; } = null!;
        public DbSet<Rate> Rates { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Zone> Zones { get; set; } = null!;
        //protected override void OnModelCreating(ModelBuilder mb)
        //{
        //    //mb.Entity<Application>()
        //    //    .HasMany<Computer>(a=>a.Installed)
        //    //    .WithMany(c=>c.Applications)
        //    //    .Map()
        //}
    }
}
