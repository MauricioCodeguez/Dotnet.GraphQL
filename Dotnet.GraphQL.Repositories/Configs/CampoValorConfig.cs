using Dotnet.GraphQL.Domain.Entities.Campos.Valor;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dotnet.GraphQL.Repositories.Configs
{
    public class CampoValorConfig : IEntityTypeConfiguration<Campo_Valor>
    {
        public void Configure(EntityTypeBuilder<Campo_Valor> builder)
        {
            builder.ToTable("Campo_Valor");

            builder
                .HasKey(x => x.ID);
        }
    }
}