using dnd.Models.Abilities;
using dnd.Models.Alignments;
using dnd.Models.Characters;
using dnd.Models.Classes;
using dnd.Models.Races;
using dnd.Models.Skills;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;

namespace dnd.Models
{
    [BindProperties(SupportsGet = true)]
    public class CharacterViewModel : PageModel
    {
        private CharacterViewModel characterViewModel { get; set; }
        public CharacterViewModel() => characterViewModel = new CharacterViewModel();
        
        private CharacterContext Context { get; set; }
        public CharacterViewModel(CharacterContext ctx) => Context = ctx;
        public Character ActiveCharacter { get; set; }
        private IEnumerable<Ability> _abilities { get; set; }
        public IEnumerable<Ability> Abilities { get => _abilities; set { _abilities = Context.Abilities.AsEnumerable(); } }
        private IEnumerable<Class> _class { get; set; }
        public IEnumerable<Class> Classes { get => _class; set { _class = Context.Classes.AsEnumerable(); } }
        private IEnumerable<Race> _races { get; set; }
        public IEnumerable<Race> Races { get => _races; set { _races = Context.Races.AsEnumerable(); } }
        private IEnumerable<Skill> _skills { get; set; }
        public IEnumerable<Skill> Skills { get => _skills; set { _skills = Context.Skills.AsEnumerable(); } }
        private IEnumerable<Character> _characters { get; set; }
        public IEnumerable<Character> Characters { get => _characters; set { _characters = Context.Characters.Where(x => x.CharacterLevel > 0).AsEnumerable(); }  }

    }
}
