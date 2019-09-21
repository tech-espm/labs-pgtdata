using Microsoft.EntityFrameworkCore;
using PGTData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PGTData.Context
{
    public class DBPGTContext : DbContext
    {
        public DBPGTContext(DbContextOptions<DBPGTContext> options)
            : base(options) { }

        public DbSet<User> User { get; set; }
        public DbSet<Campus> Campus { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<File> File { get; set; }
        public DbSet<Group> Group { get; set; }
        public DbSet<Review> Review { get; set; }
        public DbSet<ReviewType> ReviewType { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<UserType> UserType { get; set; }
        public DbSet<Warning> Warning { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<User>()
                .HasOne(x => x.UserType)
                .WithOne(y => y.User)
                .OnDelete(DeleteBehavior.Restrict);
            
        }
    }
}
