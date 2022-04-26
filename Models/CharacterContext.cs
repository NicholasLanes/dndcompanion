using dnd.Models.Abilities;
using dnd.Models.Alignments;
using dnd.Models.Characters;
using dnd.Models.Classes;
using dnd.Models.Races;
using dnd.Models.Auth;
using dnd.Models.Skills;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace dnd.Models
{
    public class CharacterContext : IdentityDbContext<User>
    {
        // importing database context options
        public CharacterContext(DbContextOptions<CharacterContext> options) : base(options) { }
        public DbSet<Alignment> Alignments { get; set; }
        public DbSet<Character> Characters { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Race> Races { get; set; }
        public DbSet<Ability> Abilities { get; set; }
        public DbSet<Skill> Skills { get; set; }

        // overriding OnModelCreating method which accepts a ModelBuilder object
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Calling the ApplyConfiguration class to import data from respective config classes
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new AlignmentConfig());
            modelBuilder.ApplyConfiguration(new ClassConfig());
            modelBuilder.ApplyConfiguration(new RaceConfig());
            modelBuilder.ApplyConfiguration(new AbilityConfig());
            modelBuilder.ApplyConfiguration(new SkillConfig());

        }


    }
}
