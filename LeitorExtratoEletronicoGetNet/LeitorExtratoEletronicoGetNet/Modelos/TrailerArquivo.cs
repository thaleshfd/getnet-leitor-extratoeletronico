namespace LeitorExtratoEletronicoGetNet.Modelos
{
    public class TrailerArquivo
    {
        [PosicaoArquivo(1, 1)]
        public string TipoRegistro { get; set; }

        [PosicaoArquivo(2, 10)]
        public decimal QuantidadeRegistros { get; set; }
    }
}
