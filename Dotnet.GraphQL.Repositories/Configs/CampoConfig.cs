using Dotnet.GraphQL.Domain.Entities.Campos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dotnet.GraphQL.Repositories.Configs
{
    public class CampoConfig : IEntityTypeConfiguration<Campo>
    {
        public void Configure(EntityTypeBuilder<Campo> builder)
        {
            builder.ToTable("Campo");

            builder
                .HasKey(x => x.ID);

            //builder
            //    .HasMany(x => x.CampoValores);
        }
    }
}