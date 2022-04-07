﻿using dnd.Models.Alignments;
using dnd.Models.Characters;
using dnd.Models.Classes;
using dnd.Models.Races;
using Microsoft.EntityFrameworkCore;

namespace dnd.Models
{
    public class CharacterContext : DbContext
    {
        // importing database context options
        public CharacterContext(DbContextOptions<CharacterContext> options) : base(options) { }
        public DbSet<Alignment> Alignments { get; set; }
        public DbSet<Character> Characters { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Race> Races { get; set; }

        // overriding OnModelCreating method which accepts a ModelBuilder object
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Calling the ApplyConfiguration class to import data from respective config classes
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new AlignmentConfig());
            modelBuilder.ApplyConfiguration(new ClassConfig());
            modelBuilder.ApplyConfiguration(new RaceConfig());

        }


    }
}