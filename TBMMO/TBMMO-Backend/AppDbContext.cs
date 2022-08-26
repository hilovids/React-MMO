using Microsoft.EntityFrameworkCore;
using TBMMO_Backend.Models;

namespace TBMMO_Backend
{
    public class AppDbContext : DbContext
    {
        public DbSet<PlayerCharacter> PlayerCharacters { get; set; }
        public DbSet<SkillSheet> SkillSheets { get; set; }
        public DbSet<ProfessionSheet> ProfessionSheets { get; set; }
        public DbSet<RelationshipSheet> RelationshipSheets { get; set; }
        public DbSet<StatSheet> StatSheets { get; set; }
        public DbSet<PlayerCharacter> Inventory { get; set; }
        public DbSet<PlayerCharacter> Clothing { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //configure our database here
            string connectionString = "Server=(localdb)\\mssqllocaldb;Database=ReactMMODB;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString).UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //insert seed data here
            base.OnModelCreating(modelBuilder);
        }
    }
}
