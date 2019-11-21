using System;
using System.Collections.Generic;

namespace LeitorExtratoEletronicoGetNet.Modelos
{
    public class ArquivoGetNet
    {
        public string NomeArquivo { get; set; }
        public DateTime DataArquivo { get; set; }
        public Header Header { get; set; }
        public List<DetalheComprovanteVenda> DetalheComprovanteVenda { get; set; } = new List<DetalheComprovanteVenda>();
        public List<DetalheOperacaoAntecipacao> DetalheOperacaoAntecipacao { get; set; } = new List<DetalheOperacaoAntecipacao>();
        public List<DetalheResumoVenda> DetalheResumoVenda { get; set; } = new List<DetalheResumoVenda>();
        public List<Ajustes> Ajustes { get; set; } = new List<Ajustes>();
        public TrailerArquivo Trailer { get; set; }
    }
}
