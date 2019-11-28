
using Blog.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Blog.Data.Context
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options): base(options)
        {}

        public DbSet<User> Users { get; set; }
        public DbSet<Blog.Data.Models.Blog> Blogs { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    CreateDate = DateTime.UtcNow,
                    Deleted = false,
                    Name = "Aşk",
                    Description = "..."
                }
                );
            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 2,
                    CreateDate = DateTime.UtcNow,
                    Deleted = false,
                    Name = "Meşk",
                    Description = "!!!"
                });
            modelBuilder.Entity<Nationality>().HasData(new Nationality()
            {
                Id = 1,
                CreateDate = DateTime.UtcNow,
                Deleted = false,
                Name = "Türkiye",
                Code = "tr"
            });
            modelBuilder.Entity<User>().HasData(new User() {
                Id = 1,
                CreateDate = DateTime.UtcNow,
                Deleted = false,
                Username = "caglar",
                Name = "Caglar",
                Surname = "Caglar",
                Email = "caglar@caglar.com",
                Password = "123456789",
                BirthDate = new DateTime(1991, 01, 01),
                Gender = Enums.Gender.Male,
                NationalityId = 1
            });
            base.OnModelCreating(modelBuilder);
        }
        
    }
}
