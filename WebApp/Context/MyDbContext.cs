using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Configurations;
using WebApp.Initializer;
using WebApp.Models;

namespace WebApp.Context
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
           

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        { 
            DataInitializer.Seed(modelBuilder); 
            modelBuilder.ApplyConfiguration(new OperationConfiguration()); 
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new BookConfiguration());

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookType> BookTypes { get; set; }
        public DbSet<Operation> Operations { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<AppUser> Users { get; set; }

    }
}
