using Dotnet.GraphQL.Domain.Entities.Clientes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dotnet.GraphQL.Repositories.Configs
{
    public class ClienteConfig : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Cliente");

            builder
                .HasKey(x => x.ID);

            builder
               .HasMany(x => x.OtherProperties)
               .WithOne(x => x.Cliente)
               .HasForeignKey(x => x.ID_Cliente);
        }
    }
}