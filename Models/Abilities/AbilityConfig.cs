using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace dnd.Models.Abilities
{
 
    internal class AbilityConfig : IEntityTypeConfiguration<Ability>
    {
        public void Configure(EntityTypeBuilder<Ability> entity)
        {
            entity.HasKey(k => k.Id); // Primary key for each alignment is the Id attribute
            entity.HasData(// Seeding alignment options
                new Ability { Id = 1, Name = "Strength" },
                new Ability { Id = 2, Name = "Dexterity" },
                new Ability { Id = 3, Name = "Constitution" },
                new Ability { Id = 4, Name = "Intelligence" },
                new Ability { Id = 5, Name = "Wisdom" },
                new Ability { Id = 6, Name = "Charisma" });
        }
    }
}
