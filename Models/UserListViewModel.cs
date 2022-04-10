using dnd.Models.Session;
using System.Collections.Generic;

namespace dnd.Models
{
    public class UserListViewModel : UserViewModel
    {
        public List<User> Users { get; set; }
    }
}
