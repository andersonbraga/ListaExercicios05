using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios05.Exercicio08
{
    internal class LataOleo
    {
        public double raio;
        public double altura;

        public double CalcularVolumeLataOleo()
        {
            return Math.PI * Math.Pow(raio, 2) * altura;
        }
    }
}
