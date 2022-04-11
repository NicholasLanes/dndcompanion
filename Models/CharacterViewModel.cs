using dnd.Models.Abilities;
using dnd.Models.Alignments;
using dnd.Models.Characters;
using dnd.Models.Classes;
using dnd.Models.Races;
using dnd.Models.Skills;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace dnd.Models
{
    public class CharacterViewModel : Character
    {
        public CharacterViewModel CharacterView { get; set; }
        public Character Character { get; set; }       
        public Ability Ability { get; set; }
        public Class Class { get; set; }
        public Race Races { get; set; }
        public Skill Skill { get; set; }


    }
}
