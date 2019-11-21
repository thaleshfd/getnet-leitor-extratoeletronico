using LeitorExtratoEletronicoGetNet.VOs;

namespace LeitorExtratoEletronicoGetNet.Modelos
{
    public class DetalheComprovanteVenda
    {

        [PosicaoArquivo(1, 1)]
        public string TipoRegistro { get; set; }

        [PosicaoArquivo(2, 16)]
        public string CodigoEstabelecimento { get; set; } //Código de Origem ou maquineta 

        [PosicaoArquivo(17, 25)]
        public decimal NumeroRv { get; set; }

        [PosicaoArquivo(26, 37)]
        public string NSUAdquirente { get; set; }

        [PosicaoArquivo(38, 45)]
        public DateGetNet DataTransacao { get; set; }

        [PosicaoArquivo(46, 51)]
        public TimeGetNet HoraTransacao { get; set; }

        [PosicaoArquivo(52, 70)]
        public string NumeroCartao { get; set; }

        [PosicaoArquivo(71, 82)]
        public MoedaGetNet ValorTransacao { get; set; }

        [PosicaoArquivo(83, 94)]
        public MoedaGetNet ValorSaque { get; set; }

        [PosicaoArquivo(95, 106)]
        public MoedaGetNet ValorTaxaEmbarque { get; set; }

        [PosicaoArquivo(107, 108)]
        public int NumeroTotalParcelas { get; set; }

        [PosicaoArquivo(109, 110)]
        public int NumeroParcela { get; set; }

        [PosicaoArquivo(111, 122)]
        public MoedaGetNet ValorParcela { get; set; }

        [PosicaoArquivo(123, 130)]
        public DateGetNet DataPagamento { get; set; }

        [PosicaoArquivo(131, 140)]
        public string CodigAutorizacao { get; set; }

        [PosicaoArquivo(141, 143)]
        public string FormaCaptura { get; set; }

        [PosicaoArquivo(144, 144)]
        public string StatusTransacao { get; set; }

        [PosicaoArquivo(145, 159)]
        public string CodigoEstabelecimentoComercialCentralizadorPagamentos { get; set; }

        [PosicaoArquivo(160, 167)]
        public string CodigoTerminal { get; set; }

        [PosicaoArquivo(168, 170)]
        public int Moeda { get; set; } //Código 986 moeda real Código 840 moeda dólar

        [PosicaoArquivo(171, 171)]
        public string OrigemEmissorCartao { get; set; }

        [PosicaoArquivo(172, 172)]
        public string SinalTransacao { get; set; } //Quando sinal(+) crédito.Quando sinal(-) débito Os sinais fazem referência ao valor líquido do resumo - sequência 14 do registro tipo 1.

        [PosicaoArquivo(173, 175)]
        public string CarteiraDigital { get; set; }

    }
}
