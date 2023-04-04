using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios05.Exercicio02
{
    internal class Temperatura
    {
        public double temperaturaF = 40;

        public double ConversaoTemperaturaParaCelsius()
        {
            return (temperaturaF - 32) / 1.8;
        }
    }
}
