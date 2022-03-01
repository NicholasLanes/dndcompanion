using dnd.Models.Chapter7Assignment;

namespace dnd.Models.User
{
    public class User
    {
        //UserId is automatically the primary key
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Grade { get; set; }
    }
}
