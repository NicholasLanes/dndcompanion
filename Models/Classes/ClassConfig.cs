﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace dnd.Models.Classes
{
    internal class ClassConfig : IEntityTypeConfiguration<Class>
    {
        public void Configure(EntityTypeBuilder<Class> entity)
        {
            entity.HasKey(k => k.Id); // Primary key for each class is the Id attribute
            entity.HasData( // Seeding class options
                new Class { Id = 0, Name = "Barbarian" },
                new Class { Id = 1, Name = "Bard" },
                new Class { Id = 2, Name = "Cleric" },
                new Class { Id = 3, Name = "Druid" },
                new Class { Id = 4, Name = "Fighter" },
                new Class { Id = 5, Name = "Monk" },
                new Class { Id = 6, Name = "Paladin" },
                new Class { Id = 7, Name = "Ranger" },
                new Class { Id = 8, Name = "Rogue" },
                new Class { Id = 9, Name = "Sorcerer" },
                new Class { Id = 10, Name = "Warlock" },
                new Class { Id = 11, Name = "Wizard" });
        }
    }
}