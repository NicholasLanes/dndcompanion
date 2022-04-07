using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace dnd.Models.Races
{
    internal class RaceConfig : IEntityTypeConfiguration<Race>
    {
        public void Configure(EntityTypeBuilder<Race> entity)
        {
            entity.HasKey(k => k.Id); // Primary key for each Race is the Id attribute
            entity.HasData( // Seeding Race options
                new Race { Id = 1, Name = "Dragonborn" },
                new Race { Id = 2, Name = "Dwarf" },
                new Race { Id = 3, Name = "Elf" },
                new Race { Id = 4, Name = "Gnome" },
                new Race { Id = 5, Name = "Half-Elf" },
                new Race { Id = 6, Name = "Halfling" },
                new Race { Id = 7, Name = "Half-Orc" },
                new Race { Id = 8, Name = "Human" },
                new Race { Id = 9, Name = "Tiefling" });
        }
    }
}
