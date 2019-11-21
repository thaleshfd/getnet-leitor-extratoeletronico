using Flunt.Notifications;
using System;
using System.Globalization;

namespace LeitorExtratoEletronicoGetNet.VOs
{
    public class TimeGetNet : Notifiable
    {
        public DateTime Value { get; set; }
        public TimeGetNet(string valor)
        {
            DateTime dataConvertida;

            if (DateTime.TryParseExact(valor, "HHmmss", null, DateTimeStyles.None, out dataConvertida))
            {
                this.Value = dataConvertida;
            }
            else
            {
                this.AddNotification("Hora", $"Formato dos dados inválidos era esperado HHmmss e foi enviado {valor}");
            }
        }

        public override string ToString()
        {
            return this.Value.ToString();
        }
    }
}
