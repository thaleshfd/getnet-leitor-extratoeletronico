using System;

namespace LeitorExtratoEletronicoGetNet
{
    public class PosicaoArquivoAttribute : Attribute
    {
        public int Inicio { get; set; }
        public int Fim { get; set; }

        public PosicaoArquivoAttribute(int inicio, int fim)
        {
            Inicio = inicio;
            Fim = fim;
        }
    }
}
