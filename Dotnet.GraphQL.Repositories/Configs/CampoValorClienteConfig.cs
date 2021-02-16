using Dotnet.GraphQL.Domain.Entities.Campos.Valor;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dotnet.GraphQL.Repositories.Configs
{
    public class CampoValorClienteConfig : IEntityTypeConfiguration<Campo_Valor_Cliente>
    {
        public void Configure(EntityTypeBuilder<Campo_Valor_Cliente> builder)
        {
            builder.ToTable("Campo_Valor_Cliente");

            builder
                .HasKey(x => x.ID);
        }
    }
}