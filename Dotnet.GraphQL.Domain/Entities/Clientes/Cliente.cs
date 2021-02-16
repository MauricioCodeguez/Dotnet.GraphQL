using Dotnet.GraphQL.Domain.Abstractions.Entities;
using Dotnet.GraphQL.Domain.Entities.Campos;
using Dotnet.GraphQL.Domain.Entities.Campos.Valor;
using System;
using System.Collections.Generic;

namespace Dotnet.GraphQL.Domain.Entities.Clientes
{
    public class Cliente : Entity<int>
    {
        protected Cliente() { }

        protected Cliente(int iD_ClientePloomes, int iD_Tipo, int? iD_Cliente, string nome, string razaoSocial, string cNPJ,
            int? iD_Relacao, int? iD_Segmento, int iD_Status, int iD_Classe, int? iD_Responsavel, int? iD_Equipe, int? iD_Grupo,
            int? iD_Origem, DateTime? dataFundacao, int? iD_QtdFuncionarios, string obs, string email, string site,
            int? iD_Cargo, int? iD_Departamento, string skype, string facebook, int? iD_Cidade, string bairro,
            string endereco, string complemento, int? cEP, string enderecoAuxiliar, string bairroAuxiliar,
            int? cEPAuxiliar, int? iD_CidadeAuxiliar, bool padronizado, int? iD_Moeda, int? iD_Lead, int? iD_Importacao,
            decimal? lat, decimal? lng, string latLng, DateTime? ultimaInteracao, string chaveExterna, int iD_Criador,
            DateTime dataCriacao, int? iD_Atualizador, DateTime? dataAtualizacao, bool suspenso, bool? recebe_EmailMkt,
            int? iD_ImportacaoAtualizacao, int? iD_ImportacaoCriacao, DateTime? data_PrimeiraTarefa, int ordemTarefas,
            string codigo_CNAE, string descricao_CNAE, string endereco_Numero, string secondaryCNAEName, string secondaryCNAECode,
            string registrationStatus, string avatarUrl, bool? hasConsent)
        {
            ID_ClientePloomes = iD_ClientePloomes;
            ID_Tipo = iD_Tipo;
            ID_Cliente = iD_Cliente;
            Nome = nome;
            RazaoSocial = razaoSocial;
            CNPJ = cNPJ;
            ID_Relacao = iD_Relacao;
            ID_Segmento = iD_Segmento;
            ID_Status = iD_Status;
            ID_Classe = iD_Classe;
            ID_Responsavel = iD_Responsavel;
            ID_Equipe = iD_Equipe;
            ID_Grupo = iD_Grupo;
            ID_Origem = iD_Origem;
            DataFundacao = dataFundacao;
            ID_QtdFuncionarios = iD_QtdFuncionarios;
            Obs = obs;
            Email = email;
            Site = site;
            ID_Cargo = iD_Cargo;
            ID_Departamento = iD_Departamento;
            Skype = skype;
            Facebook = facebook;
            ID_Cidade = iD_Cidade;
            Bairro = bairro;
            Endereco = endereco;
            Complemento = complemento;
            CEP = cEP;
            EnderecoAuxiliar = enderecoAuxiliar;
            BairroAuxiliar = bairroAuxiliar;
            CEPAuxiliar = cEPAuxiliar;
            ID_CidadeAuxiliar = iD_CidadeAuxiliar;
            Padronizado = padronizado;
            ID_Moeda = iD_Moeda;
            ID_Lead = iD_Lead;
            ID_Importacao = iD_Importacao;
            Lat = lat;
            Lng = lng;
            LatLng = latLng;
            UltimaInteracao = ultimaInteracao;
            ChaveExterna = chaveExterna;
            ID_Criador = iD_Criador;
            DataCriacao = dataCriacao;
            ID_Atualizador = iD_Atualizador;
            DataAtualizacao = dataAtualizacao;
            Suspenso = suspenso;
            Recebe_EmailMkt = recebe_EmailMkt;
            ID_ImportacaoAtualizacao = iD_ImportacaoAtualizacao;
            ID_ImportacaoCriacao = iD_ImportacaoCriacao;
            Data_PrimeiraTarefa = data_PrimeiraTarefa;
            OrdemTarefas = ordemTarefas;
            Codigo_CNAE = codigo_CNAE;
            Descricao_CNAE = descricao_CNAE;
            Endereco_Numero = endereco_Numero;
            SecondaryCNAEName = secondaryCNAEName;
            SecondaryCNAECode = secondaryCNAECode;
            RegistrationStatus = registrationStatus;
            AvatarUrl = avatarUrl;
            HasConsent = hasConsent;
            OtherProperties = new List<Campo_Valor_Cliente>();
        }

        public int ID_ClientePloomes { get; private set; }
        public int ID_Tipo { get; private set; }
        public int? ID_Cliente { get; private set; }
        public string Nome { get; private set; }
        public string RazaoSocial { get; private set; }
        public string CNPJ { get; private set; }
        public int? ID_Relacao { get; private set; }
        public int? ID_Segmento { get; private set; }
        public int ID_Status { get; private set; }
        public int ID_Classe { get; private set; }
        public int? ID_Responsavel { get; private set; }
        public int? ID_Equipe { get; private set; }
        public int? ID_Grupo { get; private set; }
        public int? ID_Origem { get; private set; }
        public DateTime? DataFundacao { get; private set; }
        public int? ID_QtdFuncionarios { get; private set; }
        public string Obs { get; private set; }
        public string Email { get; private set; }
        public string Site { get; private set; }
        public int? ID_Cargo { get; private set; }
        public int? ID_Departamento { get; private set; }
        public string Skype { get; private set; }
        public string Facebook { get; private set; }
        public int? ID_Cidade { get; private set; }
        public string Bairro { get; private set; }
        public string Endereco { get; private set; }
        public string Complemento { get; private set; }
        public int? CEP { get; private set; }
        public string EnderecoAuxiliar { get; private set; }
        public string BairroAuxiliar { get; private set; }
        public int? CEPAuxiliar { get; private set; }
        public int? ID_CidadeAuxiliar { get; private set; }
        public bool Padronizado { get; private set; }
        public int? ID_Moeda { get; private set; }
        public int? ID_Lead { get; private set; }
        public int? ID_Importacao { get; private set; }
        public decimal? Lat { get; private set; }
        public decimal? Lng { get; private set; }
        public string LatLng { get; private set; }
        public DateTime? UltimaInteracao { get; private set; }
        public string ChaveExterna { get; private set; }
        public int ID_Criador { get; private set; }
        public DateTime DataCriacao { get; private set; }
        public int? ID_Atualizador { get; private set; }
        public DateTime? DataAtualizacao { get; private set; }
        public bool Suspenso { get; private set; }
        public bool? Recebe_EmailMkt { get; private set; }
        public int? ID_ImportacaoAtualizacao { get; private set; }
        public int? ID_ImportacaoCriacao { get; private set; }
        public DateTime? Data_PrimeiraTarefa { get; private set; }
        public int OrdemTarefas { get; private set; }
        public string Codigo_CNAE { get; private set; }
        public string Descricao_CNAE { get; private set; }
        public string Endereco_Numero { get; private set; }
        public string SecondaryCNAEName { get; private set; }
        public string SecondaryCNAECode { get; private set; }
        public string RegistrationStatus { get; private set; }
        public string AvatarUrl { get; private set; }
        public bool? HasConsent { get; private set; }
        public ICollection<Campo_Valor_Cliente> OtherProperties { get; private set; }

        protected override bool Validate()
        {
            return true;
        }
    }
}