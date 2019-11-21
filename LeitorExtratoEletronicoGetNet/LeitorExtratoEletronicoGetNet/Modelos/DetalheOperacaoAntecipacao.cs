using LeitorExtratoEletronicoGetNet.VOs;

namespace LeitorExtratoEletronicoGetNet.Modelos
{
    public class DetalheOperacaoAntecipacao
    {

        [PosicaoArquivo(1, 1)]
        public string TipoRegistro { get; set; }

        [PosicaoArquivo(2, 16)]
        public string CodigoEstabelecimento { get; set; } //Código de Origem ou maquineta 

        [PosicaoArquivo(17, 24)]
        public DateGetNet DataOperacao { get; set; }

        [PosicaoArquivo(25, 32)]
        public DateGetNet DataCredito { get; set; }

        [PosicaoArquivo(33, 47)]
        public decimal NumeroOperacao { get; set; }

        [PosicaoArquivo(48, 59)]
        public MoedaGetNet ValorBrutoAntecipacao { get; set; }

        [PosicaoArquivo(60, 71)]
        public MoedaGetNet ValorTaxaAntecipacao { get; set; }

        [PosicaoArquivo(72, 83)]
        public MoedaGetNet ValorLiquidoAntecipacao { get; set; }

        [PosicaoArquivo(84, 94)]
        public int TaxaOperacaoMes { get; set; }

        [PosicaoArquivo(95, 109)]
        public string CodigoEstabelecimentoComercialCentralizadorPagamentos { get; set; }

        [PosicaoArquivo(110, 112)]
        public int Banco { get; set; }

        [PosicaoArquivo(113, 118)]
        public int Agencia { get; set; }

        [PosicaoArquivo(119, 129)]
        public decimal ContaCorrente { get; set; }

        [PosicaoArquivo(130, 132)]
        public string CanalAntecipacao { get; set; }

        [PosicaoArquivo(133, 134)]
        public string IndicadorTipoPagamento { get; set; }
    }
}
