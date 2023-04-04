using ListaExercicios05.Exercicio01;

namespace ListaExercicios05.ConsoleApp
{
    //1) Crie um programa para calcular o volume de uma caixa retangular 

    internal class Program
    {
        static void Main(string[] args)
        {
            CaixaRetangular caixaRetangular = new CaixaRetangular();
            caixaRetangular.altura = 10;
            caixaRetangular.comprimento = 10;
            caixaRetangular.largura = 10;

            Console.WriteLine(caixaRetangular.CalcularVolume());
            
        }
    }
}