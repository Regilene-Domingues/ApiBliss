using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class ChoiceMap : IEntityTypeConfiguration<ChoiceEntity>
    {
        public void Configure(EntityTypeBuilder<ChoiceEntity> builder)
        {
            builder.ToTable("Choice");
            builder.HasIndex(p => p.Choice);
            //builder.HasKey(p => p.Id);
            builder.Property(p => p.QuestionId);
        }
    }
}
