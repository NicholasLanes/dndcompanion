using dnd.Models.Characters;
using dnd.Models.Session;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace dnd.Models
{
    public class CharacterListViewModel : CharacterViewModel
    {
        private CharacterListViewModel characterListViewModel { get; set; }
        public CharacterListViewModel CharactersListViewModel 
        { 
            get => characterListViewModel; set => characterListViewModel = value; 
        }

        private List<CharacterViewModel> characterViewModels { get; set; }
        public List<CharacterViewModel> CharacterViewModels
        {
            get => characterViewModels; set => characterViewModels = value; 
        }
        private List<Character> characters { get; set; }
        public List<Character> Characters
        {
            get => characters; set => characters = value; 
        }

    }
}

