using Dotnet.GraphQL.Domain.Entities.Campos;
using Dotnet.GraphQL.Domain.Entities.Campos.Valor;
using Dotnet.GraphQL.Domain.Entities.Clientes;
using Microsoft.EntityFrameworkCore;

namespace Dotnet.GraphQL.Repositories.Contexts
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options)
            : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Campo> Campos { get; set; }
        public DbSet<Campo_Valor> CampoValores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("SQL_Latin1_General_CP1_CS_AS");
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MyDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}