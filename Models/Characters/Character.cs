using dnd.Models.Alignments;
using dnd.Models.Classes;
using dnd.Models.Races;

namespace dnd.Models.Characters
{
    public class Character
    {
        public int CharacterId { get; set; }
        public string CharacterName { get; set; }
        public Class CharacterClass { get; set; }
        public Race CharacterRace { get; set; }
        public int CharacterLevel { get; set; }
        public string CharacterBackground { get; set; }
        public Alignment Alignment { get; set; }
        public int ExperiencePoints { get; set; }
        public int StrengthVal { get; set; }
        public int DexterityVal { get; set; }
        public int ConstitutionVal { get; set; }
        public int IntelligenceVal { get; set; }
        public int WisdomVal { get; set; }
        public int CharismaVal { get; set; }
        public int InspirationVal { get; set; }
        public int ProficiencyBonusVal { get; set; }
        public string SavingThrows { get; set; }
        public string ArmorClass { get; set; }
        public int InitiativeVal { get; set; }
        public int SpeedVal { get; set; }
        public int CurrentHealth { get; set; } //Hit Point Maximum
        public int TemporaryHealth { get; set; } //Hit Point Current
        public string HitDice { get; set; }
        public int DeathSaveSuccess { get; set; }
        public int DeathSaveFailure { get; set; }
        public string PersonalityTraits { get; set; }
        public string Ideals { get; set; }
        public string Bonds { get; set; }
        public string Flaws { get; set; }
        public string Traits { get; set; }

    }
}
