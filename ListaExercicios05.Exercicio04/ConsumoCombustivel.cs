using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios05.Exercicio04
{
    internal class ConsumoCombustivel
    {
        public double kmInicial;
        public double kmFinal;
        public double consumoCombustivel;

        public double CalcularConsumoCombustivel()
        {
            return (kmFinal - kmInicial) / consumoCombustivel;
        }   
    }
}
