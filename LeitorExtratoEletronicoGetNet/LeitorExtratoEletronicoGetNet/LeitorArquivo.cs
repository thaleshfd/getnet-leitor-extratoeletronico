using LeitorExtratoEletronicoGetNet.VOs;
using System;
using System.Linq;
using System.Reflection;

namespace LeitorExtratoEletronicoGetNet
{
    public class LeitorArquivo
    {
        public T LerLinha<T>(string linha) where T : new()
        {
            var retorno = new T();

            var props = typeof(T).GetProperties().Where(x => x.GetCustomAttributes<PosicaoArquivoAttribute>().Any()).ToList();

            props.ForEach(x =>
            {
                var attr = x.GetCustomAttribute<PosicaoArquivoAttribute>();

                object valorConvertido;

                var valor = linha.Substring(attr.Inicio - 1, attr.Fim - attr.Inicio + 1);

                if (x.PropertyType == typeof(DateGetNet))
                {
                    valorConvertido = new DateGetNet(valor);
                }
                else if (x.PropertyType == typeof(TimeGetNet))
                {
                    valorConvertido = new TimeGetNet(valor);
                }
                else if (x.PropertyType == typeof(MoedaGetNet))
                {
                    valorConvertido = new MoedaGetNet(valor);
                }
                else
                {
                    valorConvertido = Convert.ChangeType(valor.Trim(), x.PropertyType);
                }


                x.SetValue(retorno, valorConvertido, null);
            });

            return retorno;
        }
    }
}
