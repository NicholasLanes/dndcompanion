using System.ComponentModel.DataAnnotations;

namespace dnd.Models.Chapter7Assignment
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Grade { get; set; }
        [Required(ErrorMessage = "Please specify an access level.")]
        [Range(1,10, ErrorMessage = "Access level must be an integer between 1 and 10.")]
        public int? AccessLevel { get; set; }
    }
}