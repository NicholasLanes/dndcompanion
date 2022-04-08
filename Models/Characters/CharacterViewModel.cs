using dnd.Models.Classes;
using dnd.Models.Races;

namespace dnd.Models.Characters
{
    /*
     * This is a view model used to present the view with
     * the character information supplied by the user.
     * This model also includes additional objects that depend
     * on class/race and other attributes.
     * If you need to call the list of all characters in 
     * the view please see CharacterListViewModel
     */

    public class CharacterViewModel : Character
    {
        public Character Character { get; set; }
        public Class Class { get; set; }
        public Race Race { get; set; }

    }
}
