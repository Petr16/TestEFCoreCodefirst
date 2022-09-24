using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace TestEFCoreCodefirst
{
    public class TestEFCoreCodefirstDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public TestEFCoreCodefirstDBContext()
        {
            //только при создании бд
            //Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=TestEFCoreCodefirstDB;Username=postgres;Password=123456");
        }
    }
}
