﻿using Microsoft.EntityFrameworkCore;
using TBMMO_Backend.Models.Items;
using TBMMO_Backend.Models.PlayerCharacter;

namespace TBMMO_Backend
{
    public class AppDbContext : DbContext
    {
        public DbSet<PlayerCharacter> PlayerCharacters { get; set; }
        public DbSet<SkillSheet> SkillSheets { get; set; }
        public DbSet<ProfessionSheet> ProfessionSheets { get; set; }
        public DbSet<RelationshipSheet> RelationshipSheets { get; set; }
        public DbSet<StatSheet> StatSheets { get; set; }
        public DbSet<Inventory> Inventory { get; set; }
        public DbSet<Clothing> Clothing { get; set; }
        public DbSet<Armor> Armor { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Food> Food { get; set; }

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
