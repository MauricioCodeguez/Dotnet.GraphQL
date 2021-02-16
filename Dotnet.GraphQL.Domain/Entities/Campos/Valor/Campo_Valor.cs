using Dotnet.GraphQL.Domain.Abstractions.Entities;
using System;

namespace Dotnet.GraphQL.Domain.Entities.Campos.Valor
{
    public class Campo_Valor : Entity<int>
    {
        protected Campo_Valor() { }

        protected Campo_Valor(int iD_Item, int iD_Campo, string valorTexto, 
            string valorTextoMultilinha, int? valorInteiro, double? valorDecimal, DateTime? valorDataHora, bool? valorBooleano, 
            int? iD_Cliente, int? iD_Oportunidade, int? iD_CotacaoRevisao, int? iD_CotacaoRevisaoTabela, int? iD_CotacaoRevisaoTabelaProduto, 
            int? iD_Produto, int? iD_VendaTabelaProduto, int? iD_Venda, int? iD_CotacaoRevisaoTabelaProdutoParte, int? iD_VendaTabela, 
            int? iD_CotacaoRevisaoParcela, int? iD_Lead, int? iD_ProdutoGrupo, int? iD_ProdutoFamilia, int? iD_Usuario, int? iD_Conta, 
            int? iD_Equipe, int? iD_OpcaoValor, int? iD_UsuarioValor, int? iD_ProdutoValor, int? iD_Documento, int? iD_DocumentoSecao, 
            int? iD_DocumentoProduto, int? iD_VendaTabelaProdutoParte, int? iD_DocumentoProdutoParte, int? iD_VendaParcela, 
            int? iD_DocumentoParcela, int? iD_ContatoRelacionado, int? iD_Tarefa, int? iD_Email, int? attachmentValueId, int? contactValueId, 
            int? currencyValueId)
        {
            ID_Item = iD_Item;
            ID_Campo = iD_Campo;
            //Valor = valor;
            //Valor_Multilinha = valor_Multilinha;
            ValorTexto = valorTexto;
            ValorTextoMultilinha = valorTextoMultilinha;
            ValorInteiro = valorInteiro;
            ValorDecimal = valorDecimal;
            ValorDataHora = valorDataHora;
            ValorBooleano = valorBooleano;
            ID_Cliente = iD_Cliente;
            ID_Oportunidade = iD_Oportunidade;
            ID_CotacaoRevisao = iD_CotacaoRevisao;
            ID_CotacaoRevisaoTabela = iD_CotacaoRevisaoTabela;
            ID_CotacaoRevisaoTabelaProduto = iD_CotacaoRevisaoTabelaProduto;
            ID_Produto = iD_Produto;
            ID_VendaTabelaProduto = iD_VendaTabelaProduto;
            ID_Venda = iD_Venda;
            ID_CotacaoRevisaoTabelaProdutoParte = iD_CotacaoRevisaoTabelaProdutoParte;
            ID_VendaTabela = iD_VendaTabela;
            ID_CotacaoRevisaoParcela = iD_CotacaoRevisaoParcela;
            ID_Lead = iD_Lead;
            ID_ProdutoGrupo = iD_ProdutoGrupo;
            ID_ProdutoFamilia = iD_ProdutoFamilia;
            ID_Usuario = iD_Usuario;
            ID_Conta = iD_Conta;
            ID_Equipe = iD_Equipe;
            ID_OpcaoValor = iD_OpcaoValor;
            ID_UsuarioValor = iD_UsuarioValor;
            ID_ProdutoValor = iD_ProdutoValor;
            ID_Documento = iD_Documento;
            ID_DocumentoSecao = iD_DocumentoSecao;
            ID_DocumentoProduto = iD_DocumentoProduto;
            ID_VendaTabelaProdutoParte = iD_VendaTabelaProdutoParte;
            ID_DocumentoProdutoParte = iD_DocumentoProdutoParte;
            ID_VendaParcela = iD_VendaParcela;
            ID_DocumentoParcela = iD_DocumentoParcela;
            ID_ContatoRelacionado = iD_ContatoRelacionado;
            ID_Tarefa = iD_Tarefa;
            ID_Email = iD_Email;
            AttachmentValueId = attachmentValueId;
            ContactValueId = contactValueId;
            CurrencyValueId = currencyValueId;
        }

        public int ID_Item { get; private set; }
        public int ID_Campo { get; private set; }
        //public object Valor { get; private set; }
        //public object Valor_Multilinha { get; private set; }
        public string ValorTexto { get; private set; }
        public string ValorTextoMultilinha { get; private set; }
        public int? ValorInteiro { get; private set; }
        public double? ValorDecimal { get; private set; }
        public DateTime? ValorDataHora { get; private set; }
        public bool? ValorBooleano { get; private set; }
        public int? ID_Cliente { get; private set; }
        public int? ID_Oportunidade { get; private set; }
        public int? ID_CotacaoRevisao { get; private set; }
        public int? ID_CotacaoRevisaoTabela { get; private set; }
        public int? ID_CotacaoRevisaoTabelaProduto { get; private set; }
        public int? ID_Produto { get; private set; }
        public int? ID_VendaTabelaProduto { get; private set; }
        public int? ID_Venda { get; private set; }
        public int? ID_CotacaoRevisaoTabelaProdutoParte { get; private set; }
        public int? ID_VendaTabela { get; private set; }
        public int? ID_CotacaoRevisaoParcela { get; private set; }
        public int? ID_Lead { get; private set; }
        public int? ID_ProdutoGrupo { get; private set; }
        public int? ID_ProdutoFamilia { get; private set; }
        public int? ID_Usuario { get; private set; }
        public int? ID_Conta { get; private set; }
        public int? ID_Equipe { get; private set; }
        public int? ID_OpcaoValor { get; private set; }
        public int? ID_UsuarioValor { get; private set; }
        public int? ID_ProdutoValor { get; private set; }
        public int? ID_Documento { get; private set; }
        public int? ID_DocumentoSecao { get; private set; }
        public int? ID_DocumentoProduto { get; private set; }
        public int? ID_VendaTabelaProdutoParte { get; private set; }
        public int? ID_DocumentoProdutoParte { get; private set; }
        public int? ID_VendaParcela { get; private set; }
        public int? ID_DocumentoParcela { get; private set; }
        public int? ID_ContatoRelacionado { get; private set; }
        public int? ID_Tarefa { get; private set; }
        public int? ID_Email { get; private set; }
        public int? AttachmentValueId { get; private set; }
        public int? ContactValueId { get; private set; }
        public int? CurrencyValueId { get; private set; }

        protected override bool Validate()
        {
            throw new NotImplementedException();
        }
    }
}
