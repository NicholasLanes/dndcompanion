using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace dnd.Models.Session
{
    internal class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> entity)
        {
            entity.HasKey(k => k.Id); // Primary key for each login is the Id attribute
            entity.HasData( // Seeding existing login options
                new User { Id = 1, Name = "John Smith", Username = "user", Password = "password", IsAdmin=false },
                new User { Id = 2, Name = "Admin Sawyer", Username = "admin", Password = "password", IsAdmin=true });
        }
    }
}
