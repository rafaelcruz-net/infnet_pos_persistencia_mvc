using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyLite.Domain.Album.ValueObject
{
    public class Duracao
    {
        public Duracao()
        {

        }

        public Duracao(int valor)
        {
            this.Valor = valor;
        }

        public int Valor { get; set; }

        public string Formatado => ValorFormatado();

        private string ValorFormatado()
        {
            var hours = Convert.ToInt32(Math.Floor(Convert.ToDecimal(this.Valor) / 3600));
            var duration = Convert.ToDecimal(hours % 3600);

            var minutos = Math.Floor(duration / 60);
            var segundos = duration % 60;

            if (hours > 0)
                return $"{hours.ToString().PadLeft(2, '0')}:{minutos.ToString().PadLeft(2, '0')}:{segundos.ToString().PadLeft(2, '0')}";

            return $"{minutos.ToString().PadLeft(2, '0')} Min  {segundos.ToString().PadLeft(2, '0')} Seg";

        }
    }
}
