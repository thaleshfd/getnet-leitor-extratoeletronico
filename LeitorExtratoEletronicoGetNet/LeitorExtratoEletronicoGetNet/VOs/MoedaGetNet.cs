using Flunt.Notifications;
using System.Globalization;

namespace LeitorExtratoEletronicoGetNet.VOs
{
    public class MoedaGetNet : Notifiable
    {
        public decimal Value { get; set; }
        public MoedaGetNet(string valor)
        {
            decimal valorConvertido;

            if (decimal.TryParse(valor, NumberStyles.None, null, out valorConvertido))
            {
                this.Value = valorConvertido / 100;
            }
            else
            {
                this.AddNotification("valor", $"Formato dos dados inválidos era esperado número e foi enviado {valor}");
            }
        }

        public override string ToString()
        {
            return this.Value.ToString();
        }
    }
}
