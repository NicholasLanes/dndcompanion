using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;

namespace dnd.Models.Characters
{
    [BindProperties(SupportsGet = true)]
    public class CharacterBindingViewModel
    {
        private CharacterBindingViewModel characterBindingViewModel { get; set; }
        public CharacterBindingViewModel() => characterBindingViewModel = new CharacterBindingViewModel();

        public CharacterViewModel characterViewModel { get; set; }
        public CharacterBindingViewModel(CharacterViewModel cvm) => characterViewModel = cvm;
        private IEnumerable<Character> characters { get; set; }
        public IEnumerable<Character> Characters { get => characters; set { characters = characterViewModel.Characters.AsEnumerable(); } }

    }
}
