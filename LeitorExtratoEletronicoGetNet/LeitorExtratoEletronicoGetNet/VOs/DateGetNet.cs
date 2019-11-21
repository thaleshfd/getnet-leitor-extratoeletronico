using Flunt.Notifications;
using System;
using System.Globalization;

namespace LeitorExtratoEletronicoGetNet.VOs
{
    public class DateGetNet : Notifiable
    {
        public DateTime Value { get; set; }
        public DateGetNet(string valor)
        {
            DateTime dataConvertida;

            if (DateTime.TryParseExact(valor, "ddMMyyyy", null, DateTimeStyles.None, out dataConvertida))
            {
                this.Value = dataConvertida;
            }
            else
            {
                this.AddNotification("Data", $"Formato dos dados inválidos era esperado ddMMyyyy e foi enviado {valor}");
            }
        }

        public override string ToString()
        {
            return this.Value.ToString();
        }
    }
}
