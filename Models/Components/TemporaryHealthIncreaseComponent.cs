using dnd.Models.Characters;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace dnd.Models.Components
{
    public class TemporaryHealthIncreaseComponent : ViewComponent
    {
        protected CharacterContext Context { get; set; }
        public TemporaryHealthIncreaseComponent(CharacterContext ctx) => Context = ctx;

        public IViewComponentResult Invoke(int id)
        {
            var characters = Context.Characters.ToList().Where(x=>x.CharacterLevel >= 1);
            var character = Context.Characters.Where(x=>x.CharacterId == id).FirstOrDefault();
            character.TemporaryHealth = character.TemporaryHealth++;
            Context.Characters.Update(character);
            Context.SaveChanges();
            var viewModel = new CharacterViewModel(Context)
            {
                Characters = characters,
                ActiveCharacter = character,

            };
            return View(viewModel);
            
        }
    }
}
