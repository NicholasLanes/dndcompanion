using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace dnd.Models.Characters
{
    internal class CharacterConfig : IEntityTypeConfiguration<Character>
    {
        public void Configure(EntityTypeBuilder<Character> entity)
        {
            entity.HasKey(k => k.CharacterId); // Primary key for each Character is the CharacterId attribute
            entity.HasData(
                new Character
                {
                    CharacterId = -1,
                    CharacterName = "Faendal",
                    CharacterClass = "Rogue",
                    CharacterRace = "Elf",
                    CharacterLevel = 1,
                    CharacterBackground = "Woodland archer",
                    Alignment = "Lawful Good",
                    ExperiencePoints = 1,
                    StrengthVal = 5,
                    DexterityVal = 7,
                    ConstitutionVal = 6,
                    IntelligenceVal = 7,
                    WisdomVal = 8,
                    CharismaVal = 3,
                    InspirationVal = 4,
                    ProficiencyBonusVal = 1,
                    SavingThrows = "Intelligence, Dexterity",
                    ArmorClass = "Light Armor",
                    InitiativeVal = 2,
                    SpeedVal = 3,
                    CurrentHealth = 10,
                    TemporaryHealth = 8,
                    HitDice = "D8",
                    DeathSaveSuccess = 0,
                    DeathSaveFailure = 1,
                    PersonalityTraits = "Quiet, Mild-Mannered, Investigatory",
                    Ideals = "The Greater Good Supasses all Individual Needs.",
                    Bonds = "Woodland Creatures",
                    Flaws = "Poor Eyesight.",
                    Traits = "Speaks Elven dialects as well as Human dialects."
                });
        }
    }
}
