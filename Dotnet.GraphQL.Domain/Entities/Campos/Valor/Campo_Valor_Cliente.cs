using Dotnet.GraphQL.Domain.Abstractions.Entities;
using Dotnet.GraphQL.Domain.Entities.Clientes;
using System;

namespace Dotnet.GraphQL.Domain.Entities.Campos.Valor
{
    public class Campo_Valor_Cliente : Entity<int>
    {
        protected Campo_Valor_Cliente() {}

        protected Campo_Valor_Cliente(int iD_Cliente, int iD_Campo, string valorTexto, string valorTextoMultilinha, int? valorInteiro, 
            double? valorDecimal, DateTime? valorDataHora, bool? valorBooleano, int? iD_OpcaoValor, int? iD_UsuarioValor, 
            int? iD_ProdutoValor, int? attachmentValueId, int? contactValueId, int? currencyValueId)
        {
            ID_Cliente = iD_Cliente;
            ID_Campo = iD_Campo;
            ValorTexto = valorTexto;
            ValorTextoMultilinha = valorTextoMultilinha;
            ValorInteiro = valorInteiro;
            ValorDecimal = valorDecimal;
            ValorDataHora = valorDataHora;
            ValorBooleano = valorBooleano;
            ID_OpcaoValor = iD_OpcaoValor;
            ID_UsuarioValor = iD_UsuarioValor;
            ID_ProdutoValor = iD_ProdutoValor;
            AttachmentValueId = attachmentValueId;
            ContactValueId = contactValueId;
            CurrencyValueId = currencyValueId;
        }

        public int ID_Cliente { get; private set; }
        public int ID_Campo { get; private set; }
        public string ValorTexto { get; private set; }
        public string ValorTextoMultilinha { get; private set; }
        public int? ValorInteiro { get; private set; }
        public double? ValorDecimal { get; private set; }
        public DateTime? ValorDataHora { get; private set; }
        public bool? ValorBooleano { get; private set; }
        public int? ID_OpcaoValor { get; private set; }
        public int? ID_UsuarioValor { get; private set; }
        public int? ID_ProdutoValor { get; private set; }
        public int? AttachmentValueId { get; private set; }
        public int? ContactValueId { get; private set; }
        public int? CurrencyValueId { get; private set; }
        public Cliente Cliente { get; private set; }

        protected override bool Validate()
        {
            return true;
        }
    }
}
