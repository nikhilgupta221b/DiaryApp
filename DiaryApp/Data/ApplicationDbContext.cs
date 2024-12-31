using DiaryApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DiaryApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        
        public DbSet<DiaryEntry> DiaryEntries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<DiaryEntry>().HasData(
                new DiaryEntry
                {
                    Id = 1,
                    Title = "Went Hiking",
                    Content = "Went hiking with Joe",
                    Created = new DateTime(2025, 1, 1, 0, 0, 0)
                },
                new DiaryEntry
                {
                    Id = 2,
                    Title = "Went Biking",
                    Content = "Went biking with Joe",
                    Created = new DateTime(2025, 1, 1, 0, 0, 0)
                },
                new DiaryEntry
                {
                    Id = 3,
                    Title = "Went Shopping",
                    Content = "Went shopping with Joe",
                    Created = new DateTime(2025, 1, 1, 0, 0, 0)
                }
                );
        }
    }
}
