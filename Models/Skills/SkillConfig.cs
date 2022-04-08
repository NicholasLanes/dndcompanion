using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace dnd.Models.Skills
{
    internal class SkillConfig : IEntityTypeConfiguration<Skill>
    {
        public void Configure(EntityTypeBuilder<Skill> entity)
        {
            entity.HasKey(k => k.Id); // Primary key for each Race is the Id attribute
            entity.HasData( // Seeding Race options
                new Skill { Id = 1, Name = "Acrobatics", AbilityModifier="Dexterity" },
                new Skill { Id = 2, Name = "Animal Handling", AbilityModifier="Wisdom" },
                new Skill { Id = 3, Name = "Arcana", AbilityModifier="Intelligence"},
                new Skill { Id = 4, Name = "Athletics", AbilityModifier="Strength" },
                new Skill { Id = 5, Name = "Deception", AbilityModifier="Charisma" },
                new Skill { Id = 6, Name = "History", AbilityModifier="Intelligence" },
                new Skill { Id = 7, Name = "Insight", AbilityModifier="Wisdom" },
                new Skill { Id = 8, Name = "Intimidation", AbilityModifier="Charisma" },
                new Skill { Id = 9, Name = "Investigation", AbilityModifier="Intelligence"},
                new Skill { Id = 10, Name="Medicine", AbilityModifier="Wisdom"},
                new Skill { Id=11,Name="Nature",AbilityModifier="Intelligence"},
                new Skill { Id=12,Name="Perception",AbilityModifier="Wisdom"},
                new Skill { Id=13,Name="Performance",AbilityModifier="Charisma"},
                new Skill { Id=14,Name="Persuasion", AbilityModifier="Charisma"},
                new Skill { Id=15,Name="Religion", AbilityModifier="Intelligence"},
                new Skill { Id=16,Name="Sleight of Hand",AbilityModifier="Dexterity"},
                new Skill { Id=17,Name="Stealth",AbilityModifier="Dexterity"},
                new Skill { Id=18,Name="Survival",AbilityModifier="Wisdom"});
        }
    }
}
