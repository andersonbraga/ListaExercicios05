using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios05.Exercicio07
{
    internal class SalarioVendedor
    {
        public double salarioBase;
        public double totalVendas;
        public double percentual;

        public double CalcularSalarioVendedor()
        {
            return totalVendas * percentual + salarioBase;
        }
    }
}
