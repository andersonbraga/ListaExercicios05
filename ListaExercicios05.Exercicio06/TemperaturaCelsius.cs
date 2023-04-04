using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios05.Exercicio06
{
    internal class TemperaturaCelsius
    {
        public double temperaturaC;

        public double ConverterTemperaturaParaF()
        {
            return temperaturaC * 1.8 + 32;
        }
    }
}
