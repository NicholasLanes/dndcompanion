using dnd.Models.Alignments;
using dnd.Models.Classes;
using dnd.Models.Races;
using Microsoft.AspNetCore.Mvc;

namespace dnd.Models.Characters
{
    // This Character Class includes all possible fields for a character sheet
    [BindProperties(SupportsGet = true)]
    public class Character
    {
        public int CharacterId { get; set; } = 0;// Primary Key
        public string CharacterName { get; set; } = "Faendal"; // Name of the Character
        public string CharacterClass { get; set; } = "Rogue"; // Selected Class
        public string CharacterRace { get; set; } = "Elf"; // Selected Race
        public int CharacterLevel { get; set; } = 1; // Character Level
        public string CharacterBackground { get; set; } = "Woodland Archer"; // Background Information for the Character
        public string Alignment { get; set; } = "Lawful Good"; // Moral Alignment
        public int ExperiencePoints { get; set; } = 1; // Experience Points
        public int StrengthVal { get; set; } = 5; // Strength Value
        public int DexterityVal { get; set; } = 5; // Dexterity Value
        public int ConstitutionVal { get; set; } = 5; // Constitution Value
        public int IntelligenceVal { get; set; } = 5; // Intelligence Value
        public int WisdomVal { get; set; } = 5; // Wisdom Value
        public int CharismaVal { get; set; } = 5; // Charisma Value
        public int InspirationVal { get; set; } = 5; // Inspiration Value
        public int ProficiencyBonusVal { get; set; } = 5; // Proficiency Bonus Value
        public string SavingThrows { get; set; } = "Intelligence, Dexterity"; // Saving Throws (Type)
        public string ArmorClass { get; set; } = "Light Armor"; // Armor Able to be Equipped
        public int InitiativeVal { get; set; } = 5; // Initiative Value
        public int SpeedVal { get; set; } = 5; // Speed Value
        public int CurrentHealth { get; set; } = 5; // Hit Point Maximum
        public int TemporaryHealth { get; set; } = 5; // Hit Point Current
        public string HitDice { get; set; } = "D8"; // Which Die is rolled when the player attacks
        public int DeathSaveSuccess { get; set; } = 5; // Number of Successful Death Saves
        public int DeathSaveFailure { get; set; } = 5; // Number of Unsuccessful Death Saves
        public string PersonalityTraits { get; set; } = "Quiet, Mild-Mannered, Investigatory"; // Personality Traits
        public string Ideals { get; set; } = "The Greater Good Supasses all Individual Needs."; // Character Ideals
        public string Bonds { get; set; } = "Woodland Creatures"; // Character Bonds
        public string Flaws { get; set; } = "Poor Eyesight";// Character Flaws
        public string Traits { get; set; } = "Speaks Elven dialects as well as Human dialects."; // Additional Traits and Languages

    }
}
