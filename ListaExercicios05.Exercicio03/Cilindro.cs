using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios05.Exercicio03
{
    internal class Cilindro
    {
        public double raio;
        public double altura;
        

        public double CalcularVolumeCilindro()
        {
            return  Math.PI * altura * Math.Pow(raio, 2);
        }
    }
}
