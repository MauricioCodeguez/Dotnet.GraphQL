using Dotnet.GraphQL.Api.GraphQL.Types.Campos;
using Dotnet.GraphQL.Domain.Entities.Campos.Valor;
using Dotnet.GraphQL.Domain.Entities.Clientes;
using Dotnet.GraphQL.Services;
using GraphQL;
using GraphQL.Types;
using GraphQL.Utilities;
using System.Collections.Generic;

namespace Dotnet.GraphQL.Api.GraphQL.Types.Clientes
{
    public class ClienteGraphType : ObjectGraphType<Cliente>
    {
        public ClienteGraphType()
        {
            Name = "cliente";

            Field(x => x.ID, type: typeof(IntGraphType));
            Field(x => x.ID_ClientePloomes);
            Field(x => x.ID_Tipo);
            Field(x => x.ID_Cliente, nullable: true);
            Field(x => x.Nome);
            Field(x => x.RazaoSocial, nullable: true);
            Field(x => x.CNPJ, nullable: true);
            Field(x => x.ID_Relacao, nullable: true);
            Field(x => x.ID_Segmento, nullable: true);
            Field(x => x.Email, nullable: true);
            Field(x => x.ID_Cidade, nullable: true);
            Field(x => x.Bairro, nullable: true);
            Field(x => x.Endereco, nullable: true);
            Field(x => x.Complemento, nullable: true);
            Field(x => x.ID_Criador);
            Field(x => x.DataCriacao);
            Field(x => x.ID_Atualizador, nullable: true);
            Field(x => x.DataAtualizacao, nullable: true);
            Field(x => x.Suspenso);
            Field(x => x.AvatarUrl, nullable: true);

            FieldAsync<ListGraphType<CampoValorClienteGraphType>, IEnumerable<Campo_Valor_Cliente>>(
                name: "otherproperties",
                resolve: async context =>
                {
                    var fields = await context.RequestServices.GetRequiredService<IClienteService>().GetFields(context.Source.ID, context.CancellationToken);
                    return fields;
                });

            FieldAsync<CampoValorClienteGraphType>(
                name: "otherproperty",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IdGraphType>> { Name = "id" }),
                resolve: async context =>
                {
                    var id = context.GetArgument<int>("id");
                    if (Equals(id, default(int))) context.Errors.Add(new ExecutionError($"Invalid Id: {id}"));

                    var cliente = await context.RequestServices
                        .GetRequiredService<ICampoValorClienteService>()
                        .GetByIdAsync(
                            id: id,
                            cancellationToken: context.CancellationToken);

                    return cliente;
                });
        }
    }
}