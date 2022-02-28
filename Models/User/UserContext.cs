using dnd.Models.Chapter7Assignment;
using Microsoft.EntityFrameworkCore;
namespace dnd.Models.User
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        //The Students DbSet only adds an access level parameter
        public DbSet<Student> Students { get; set; }
        //Seeding initial data in the database
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    Id = 1,
                    FirstName = "Nicholas",
                    LastName = "Lanes",
                    Grade = "A"
                },
                new Student
                {
                    Id=2,
                    FirstName ="James",
                    LastName ="Smith",
                    Grade="B"
                },
                new Student
                {
                    Id = 3,
                    FirstName = "John",
                    LastName ="Smith",
                    Grade="C"
                },
                new Student
                {
                    Id = 4,
                    FirstName = "Sebastian",
                    LastName="Bach",
                    Grade="A"
                },
                new Student
                {
                    Id = 5,
                    FirstName = "Samuel",
                    LastName="Jackson",
                    Grade="B"
                }
                );
            modelBuilder.Entity<User>().HasData(
            new User
            {
                UserId = 1,
                FirstName = "Nicholas",
                LastName = "Lanes",
                Email = "email@test.com",
                Password = "pass",
                Grade = "A",
            },
            new User
            {
                UserId = 2,
                FirstName = "James",
                LastName = "Franco",
                Email = "jfranc@gmail.com",
                Password = "francooo",
                Grade = "B"
            },
            new User
            {
                UserId = 3,
                FirstName = "Michael",
                LastName = "Scarn",
                Email = "itsamemike@aol.com",
                Password = "dementors",
                Grade = "D"
            },
            new User
            {
                UserId = 4,
                FirstName = "Hank",
                LastName = "Hill",
                Email = "dangitbobby@stricklandpropane.org",
                Password = "charcoal",
                Grade = "A"
            },
            new User
            {
                UserId = 5,
                FirstName = "Sebastian",
                LastName = "Crowley",
                Email = "crowley1@gmail.com",
                Password = "crowdown",
                Grade = "C+"
            }
            );
        }
    }
}
