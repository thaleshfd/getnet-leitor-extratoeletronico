using LeitorExtratoEletronicoGetNet.VOs;

namespace LeitorExtratoEletronicoGetNet.Modelos
{
    public class Ajustes
    {
        [PosicaoArquivo(1, 1)]
        public string TipoRegistro { get; set; }

        [PosicaoArquivo(2, 16)]
        public string CodigoEstabelecimento { get; set; } //Código de Origem ou maquineta 

        [PosicaoArquivo(17, 25)]
        public decimal NumeroRVAjustado { get; set; }

        [PosicaoArquivo(26, 33)]
        public DateGetNet DataRV { get; set; }

        [PosicaoArquivo(34, 41)]
        public DateGetNet DataPagamentoRV { get; set; }

        [PosicaoArquivo(42, 61)]
        public double IdentificadorAjuste { get; set; }

        [PosicaoArquivo(62, 62)]
        public string Brancos { get; set; }

        [PosicaoArquivo(63, 63)]
        public string SinalTransacao { get; set; }

        [PosicaoArquivo(64, 75)]
        public MoedaGetNet ValorAjuste { get; set; }

        [PosicaoArquivo(76, 77)]
        public string MotivoAjuste { get; set; }

        [PosicaoArquivo(78, 85)]
        public DateGetNet DataCarta { get; set; }

        [PosicaoArquivo(86, 104)]
        public string NumeroCartao { get; set; }

        [PosicaoArquivo(105, 113)]
        public string NumeroRVOriginal { get; set; }

        [PosicaoArquivo(114, 125)]
        public string NumeroCV { get; set; }

        [PosicaoArquivo(126, 133)]
        public DateGetNet DataTransacaoOriginal { get; set; }

        [PosicaoArquivo(134, 135)]
        public string IndicadorTipoPagamento { get; set; }

        [PosicaoArquivo(136, 143)]
        public string NumeroTerminal { get; set; }

        [PosicaoArquivo(144, 151)]
        public DateGetNet DataPagamentoOriginal { get; set; }

        [PosicaoArquivo(152, 154)]
        public string Moeda { get; set; }
    }
}
