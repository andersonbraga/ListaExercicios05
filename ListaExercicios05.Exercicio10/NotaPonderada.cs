using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios05.Exercicio10
{
    internal class NotaPonderada
    {
        public double nota1;
        public double nota2;
        public double nota3;

        public double CalcularNotaPonderada()
        {
            return (nota1 + nota2 + nota3) / 3;
        }
    }
}
