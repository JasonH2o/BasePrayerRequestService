using DataAccessLayer.Configurations;
using Microsoft.EntityFrameworkCore;
using PrayerRequestCore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public class PrayerDbContext: DbContext
    {
        public DbSet<Prayer> Prayers { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<User> Users { get; set; }

        public PrayerDbContext(DbContextOptions<PrayerDbContext> options): base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new PrayerConfiguration());
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new CommentConfiguration());
        }
    }
}
