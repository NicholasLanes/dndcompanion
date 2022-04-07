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
        public string CharacterAlignment { get; set; }
        public int ExperiencePoints { get; set; }
        public string PlayerName { get; set; }

    }
}
