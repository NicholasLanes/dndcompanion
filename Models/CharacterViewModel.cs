using dnd.Models.Characters;
using dnd.Models.Session;
using Microsoft.AspNetCore.Http;

namespace dnd.Models
{
    public class CharacterViewModel
    {
        private Character character;

        public Character Character 
        { 
            get => character;
            set
            {
                character = value;
            }
        }
    }
}
