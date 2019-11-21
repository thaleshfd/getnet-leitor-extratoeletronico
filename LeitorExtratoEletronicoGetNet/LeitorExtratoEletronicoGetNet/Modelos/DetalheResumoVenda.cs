using LeitorExtratoEletronicoGetNet.VOs;
using System;

namespace LeitorExtratoEletronicoGetNet.Modelos
{
    public class DetalheResumoVenda
    {

        [PosicaoArquivo(1, 1)]
        public string TipoRegistro { get; set; }

        [PosicaoArquivo(2, 16)]
        public string CodigoEstabelecimento { get; set; }

        [PosicaoArquivo(17, 18)]
        public string CodigoProduto { get; set; }

        [PosicaoArquivo(19, 21)]
        public string FormaCaptura { get; set; }

        [PosicaoArquivo(22, 30)]
        public int NumeroRV { get; set; }

        [PosicaoArquivo(31, 38)]
        public DateGetNet DataRV { get; set; } //DataProcessamento

        [PosicaoArquivo(39, 46)]
        public DateGetNet DataPagamentoRV { get; set; } //para as vendas indica a previsão do pgto para o financeiro é a data de pagto

        [PosicaoArquivo(47, 49)]
        public int Banco { get; set; }

        [PosicaoArquivo(50, 55)]
        public int Agencia { get; set; }

        [PosicaoArquivo(56, 66)]
        public decimal ContaCorrente { get; set; }

        [PosicaoArquivo(67, 75)]
        public Int32 NumeroCVAceitos { get; set; }

        [PosicaoArquivo(76, 84)]
        public Int32 NumeroCVRejeitados { get; set; }

        [PosicaoArquivo(85, 96)]
        public MoedaGetNet ValorBruto { get; set; }

        [PosicaoArquivo(97, 108)]
        public MoedaGetNet ValorLiquido { get; set; }

        [PosicaoArquivo(109, 120)]
        public MoedaGetNet ValorTarifa { get; set; }

        [PosicaoArquivo(121, 132)]
        public MoedaGetNet ValorTaxaDesconto { get; set; }

        [PosicaoArquivo(133, 144)]
        public MoedaGetNet ValorRejeitado { get; set; }

        [PosicaoArquivo(145, 156)]
        public MoedaGetNet ValorCredito { get; set; }

        [PosicaoArquivo(157, 168)]
        public MoedaGetNet ValorEncargos { get; set; } //Ex.: antecipação
                                                       //‘PF’ – Previsão de Pagamento Futuro 
                                                       //‘PG’ – Pagamento Normal 
                                                       //‘AC’ – Antecipação de Crédito 
                                                       //‘RA’ – Rejeição de Antecipação 
                                                       //‘PR’ – Pagamento da Antecipação Rejeitada 
                                                       //´PD´ - Pagamento Pendente 
                                                       //´CI´ - Cobrança Interna

        [PosicaoArquivo(169, 170)]
        public string IndicadorTipoPagamento { get; set; }

        [PosicaoArquivo(171, 172)]
        public int NumeroParcelaRV { get; set; }

        [PosicaoArquivo(173, 174)]
        public int QuantidadesParcelasRV { get; set; }

        [PosicaoArquivo(175, 189)]
        public string CodigoEstabelecimentoComercialCentralizadorPagamentos { get; set; }

        [PosicaoArquivo(190, 204)]
        public int NumeroOperacaoAntecipacao { get; set; }

        [PosicaoArquivo(205, 212)]
        public DateGetNet DataVencimentoOriginalRVAntecipado { get; set; }

        [PosicaoArquivo(213, 224)]
        public int CustoOperacao { get; set; }

        [PosicaoArquivo(225, 236)]
        public decimal ValorLiquidoRVAntecipado { get; set; }

        [PosicaoArquivo(237, 254)]
        public decimal NumeroControleOperacaoCobranca { get; set; }

        [PosicaoArquivo(255, 266)]
        public string ValorLiquidoCobranca { get; set; } //(Aluguel de POS ou ajuste de serviços) 

        [PosicaoArquivo(267, 281)]
        public decimal IdCompensacao { get; set; }

        [PosicaoArquivo(282, 284)]
        public int Moeda { get; set; } //Código 986 moeda real Código 840 moeda dólar

        [PosicaoArquivo(285, 285)]
        public string IdentificadorBaixaCobrancaServicoExterna { get; set; }

        [PosicaoArquivo(286, 286)]
        public string SinalTransacao { get; set; } //Quando sinal(+) crédito.Quando sinal(-) débito Os sinais fazem referência ao valor líquido do resumo - sequência 14 do registro tipo 1.
    }
}


