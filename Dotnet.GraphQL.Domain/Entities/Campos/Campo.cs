using Dotnet.GraphQL.Domain.Abstractions.Entities;
using Dotnet.GraphQL.Domain.Entities.Campos.Valor;
using System;
using System.Collections.Generic;

namespace Dotnet.GraphQL.Domain.Entities.Campos
{
    public class Campo : Entity<int>
    {
        protected Campo() { }

        //protected Campo(int iD_ClientePloomes, int iD_Tabela, int? iD_TabelaEstrangeira, int? iD_TabelaEstrangeiraFixa, string descricao, 
        //    string chave, int iD_Tipo, int iD_Formato, int? iD_Item, int? iD_TipoItem, string formula, string formulaExternaUrl, 
        //    string formulaExternaRequestBody, string formulaExternaMethod, string formulaExternaHeaders, string label, 
        //    bool bloqueado, bool obrigatorio, bool multiplo, bool unico, bool filtro, int ordem, 
        //    bool suspenso, int iD_Criador, DateTime dataCriacao, int? iD_Atualizador, DateTime? dataAtualizacao, string valorTextoPadrao, 
        //    string valorTextoMultilinhaPadrao, int? valorInteiroPadrao, double? valorDecimalPadrao, DateTime? valorDataHoraPadrao, 
        //    bool? valorBooleanoPadrao, bool expandido, bool formulaEditor, bool oculto, bool integracao, int? integrationCustomFieldId, 
        //    bool autoParagraph, int columnSize, bool? useCheckbox, int? filterId, string fieldHideFormula, string fieldDisableFormula, 
        //    bool? inlineEditTriggerDocumentGeneration, bool? isSensitiveData, bool? showTime)
        //{
        //    ID_ClientePloomes = iD_ClientePloomes;
        //    ID_Tabela = iD_Tabela;
        //    ID_TabelaEstrangeira = iD_TabelaEstrangeira;
        //    ID_TabelaEstrangeiraFixa = iD_TabelaEstrangeiraFixa;
        //    Descricao = descricao;
        //    Chave = chave;
        //    ID_Tipo = iD_Tipo;
        //    ID_Formato = iD_Formato;
        //    ID_Item = iD_Item;
        //    ID_TipoItem = iD_TipoItem;
        //    Formula = formula;
        //    FormulaExternaUrl = formulaExternaUrl;
        //    FormulaExternaRequestBody = formulaExternaRequestBody;
        //    FormulaExternaMethod = formulaExternaMethod;
        //    FormulaExternaHeaders = formulaExternaHeaders;
        //    Label = label;
        //    //ValorPadrao = valorPadrao;
        //    Bloqueado = bloqueado;
        //    Obrigatorio = obrigatorio;
        //    Multiplo = multiplo;
        //    Unico = unico;
        //    Filtro = filtro;
        //    Ordem = ordem;
        //    Suspenso = suspenso;
        //    ID_Criador = iD_Criador;
        //    DataCriacao = dataCriacao;
        //    ID_Atualizador = iD_Atualizador;
        //    DataAtualizacao = dataAtualizacao;
        //    ValorTextoPadrao = valorTextoPadrao;
        //    ValorTextoMultilinhaPadrao = valorTextoMultilinhaPadrao;
        //    ValorInteiroPadrao = valorInteiroPadrao;
        //    ValorDecimalPadrao = valorDecimalPadrao;
        //    ValorDataHoraPadrao = valorDataHoraPadrao;
        //    ValorBooleanoPadrao = valorBooleanoPadrao;
        //    Expandido = expandido;
        //    FormulaEditor = formulaEditor;
        //    Oculto = oculto;
        //    Integracao = integracao;
        //    IntegrationCustomFieldId = integrationCustomFieldId;
        //    AutoParagraph = autoParagraph;
        //    ColumnSize = columnSize;
        //    UseCheckbox = useCheckbox;
        //    FilterId = filterId;
        //    FieldHideFormula = fieldHideFormula;
        //    FieldDisableFormula = fieldDisableFormula;
        //    InlineEditTriggerDocumentGeneration = inlineEditTriggerDocumentGeneration;
        //    IsSensitiveData = isSensitiveData;
        //    ShowTime = showTime;
        //    CampoValores = new List<Campo_Valor>();
        //}

        //public int ID_ClientePloomes { get; private set; }
        //public int ID_Tabela { get; private set; }
        //public int? ID_TabelaEstrangeira { get; private set; }
        //public int? ID_TabelaEstrangeiraFixa { get; private set; }
        //public string Descricao { get; private set; }
        //public string Chave { get; private set; }
        //public int ID_Tipo { get; private set; }
        //public int ID_Formato { get; private set; }
        //public int? ID_Item { get; private set; }
        //public int? ID_TipoItem { get; private set; }
        //public string Formula { get; private set; }
        //public string FormulaExternaUrl { get; private set; }
        //public string FormulaExternaRequestBody { get; private set; }
        //public string FormulaExternaMethod { get; private set; }
        //public string FormulaExternaHeaders { get; private set; }
        //public string Label { get; private set; }
        ////public object ValorPadrao { get; private set; }
        //public bool Bloqueado { get; private set; }
        //public bool Obrigatorio { get; private set; }
        //public bool Multiplo { get; private set; }
        //public bool Unico { get; private set; }
        //public bool Filtro { get; private set; }
        //public int Ordem { get; private set; }
        //public bool Suspenso { get; private set; }
        //public int ID_Criador { get; private set; }
        //public DateTime DataCriacao { get; private set; }
        //public int? ID_Atualizador { get; private set; }
        //public DateTime? DataAtualizacao { get; private set; }
        //public string ValorTextoPadrao { get; private set; }
        //public string ValorTextoMultilinhaPadrao { get; private set; }
        //public int? ValorInteiroPadrao { get; private set; }
        //public double? ValorDecimalPadrao { get; private set; }
        //public DateTime? ValorDataHoraPadrao { get; private set; }
        //public bool? ValorBooleanoPadrao { get; private set; }
        //public bool Expandido { get; private set; }
        //public bool FormulaEditor { get; private set; }
        //public bool Oculto { get; private set; }
        //public bool Integracao { get; private set; }
        //public int? IntegrationCustomFieldId { get; private set; }
        //public bool AutoParagraph { get; private set; }
        //public int ColumnSize { get; private set; }
        //public bool? UseCheckbox { get; private set; }
        //public int? FilterId { get; private set; }
        //public string FieldHideFormula { get; private set; }
        //public string FieldDisableFormula { get; private set; }
        //public bool? InlineEditTriggerDocumentGeneration { get; private set; }
        //public bool? IsSensitiveData { get; private set; }
        //public bool? ShowTime { get; private set; }
        //public ICollection<Campo_Valor> CampoValores { get; private set; }

        protected Campo(string descricao)
        {
            Descricao = descricao;
        }

        public string Descricao { get; private set; }

        protected override bool Validate()
        {
            return true;
        }
    }
}
