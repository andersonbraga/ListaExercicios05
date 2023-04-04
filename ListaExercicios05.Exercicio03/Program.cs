namespace ListaExercicios05.Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cilindro cilindro = new Cilindro();
            cilindro.altura = 3;
            cilindro.raio = 4;
            Console.WriteLine(cilindro.CalcularVolumeCilindro());
        }
    }
}