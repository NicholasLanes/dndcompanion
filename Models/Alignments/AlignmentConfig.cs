using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace dnd.Models.Alignments
{
    internal class AlignmentConfig:IEntityTypeConfiguration<Alignment>
    {
        public void Configure(EntityTypeBuilder<Alignment> entity)
        {
            entity.HasKey(k => k.Id); // Primary key for each alignment is the Id attribute
            entity.HasData(// Seeding alignment options
                new Alignment { Id=0, Name="Lawful Good"},
                new Alignment { Id=1, Name="Neutral Good"},
                new Alignment { Id=2, Name="Chaotic Good"},
                new Alignment { Id=3, Name="Lawful Neutral"},
                new Alignment { Id=4, Name="True Neutral"},
                new Alignment { Id=5, Name="Chaotic Neutral"},
                new Alignment { Id=6, Name="Lawful Evil"},
                new Alignment { Id=7, Name="Neutral Evil"},
                new Alignment { Id=8, Name="Chaotic Evil"});
        }
    }
}
