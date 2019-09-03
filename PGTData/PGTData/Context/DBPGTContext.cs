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
        public DbSet<Professor_PGT> Professor_PGT { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Professor_PGT>()
                    .HasOne(p => p.User)
                        .WithMany(b => b.Professor_PGT)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
