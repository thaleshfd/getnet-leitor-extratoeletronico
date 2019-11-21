using LeitorExtratoEletronicoGetNet.VOs;

namespace LeitorExtratoEletronicoGetNet.Modelos
{
    public class Header
    {
        [PosicaoArquivo(1, 1)]
        public string TipoRegistro { get; set; }

        [PosicaoArquivo(2, 9)]
        public DateGetNet DataCriacaoArquivo { get; set; }

        [PosicaoArquivo(10, 15)]
        public TimeGetNet HoraCriacaoArquivo { get; set; }

        [PosicaoArquivo(16, 23)]
        public DateGetNet DataReferenciaMovimento { get; set; }

        [PosicaoArquivo(24, 31)]
        public string VersaoArquivo { get; set; }

        [PosicaoArquivo(32, 46)]
        public string CodigoEstabelecimento { get; set; }

        [PosicaoArquivo(47, 60)]
        public decimal CNPJAdquirente { get; set; }

        [PosicaoArquivo(61, 80)]
        public string NomeAdquirente { get; set; }

        [PosicaoArquivo(81, 89)]
        public decimal SequencialRemessa { get; set; }

        [PosicaoArquivo(90, 91)]
        public string CodigoAdquirente { get; set; }

        [PosicaoArquivo(92, 116)]
        public string VersaoLayout { get; set; }
    }
}
