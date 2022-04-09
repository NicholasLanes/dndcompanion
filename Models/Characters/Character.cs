using dnd.Models.Alignments;
using dnd.Models.Classes;
using dnd.Models.Races;

namespace dnd.Models.Characters
{
    // This Character Class includes all possible fields for a character sheet
    public class Character
    {
        public int CharacterId { get; set; } // Primary Key
        public string CharacterName { get; set; } // Name of the Character
        public string CharacterClass { get; set; } // Selected Class
        public string CharacterRace { get; set; } // Selected Race
        public int CharacterLevel { get; set; } // Character Level
        public string CharacterBackground { get; set; } // Background Information for the Character
        public string Alignment { get; set; } // Moral Alignment
        public int ExperiencePoints { get; set; } // Experience Points
        public int StrengthVal { get; set; } // Strength Value
        public int DexterityVal { get; set; } // Dexterity Value
        public int ConstitutionVal { get; set; } // Constitution Value
        public int IntelligenceVal { get; set; } // Intelligence Value
        public int WisdomVal { get; set; } // Wisdom Value
        public int CharismaVal { get; set; } // Charisma Value
        public int InspirationVal { get; set; } // Inspiration Value
        public int ProficiencyBonusVal { get; set; } // Proficiency Bonus Value
        public string SavingThrows { get; set; } // Saving Throws (Type)
        public string ArmorClass { get; set; } // Armor Able to be Equipped
        public int InitiativeVal { get; set; } // Initiative Value
        public int SpeedVal { get; set; } // Speed Value
        public int CurrentHealth { get; set; } // Hit Point Maximum
        public int TemporaryHealth { get; set; } // Hit Point Current
        public string HitDice { get; set; } // Which Die is rolled when the player attacks
        public int DeathSaveSuccess { get; set; } // Number of Successful Death Saves
        public int DeathSaveFailure { get; set; } // Number of Unsuccessful Death Saves
        public string PersonalityTraits { get; set; } // Personality Traits
        public string Ideals { get; set; } // Character Ideals
        public string Bonds { get; set; } // Character Bonds
        public string Flaws { get; set; } // Character Flaws
        public string Traits { get; set; } // Additional Traits and Languages

    }
}
