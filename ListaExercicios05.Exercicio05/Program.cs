namespace ListaExercicios05.Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Esfera esfera = new Esfera();
            esfera.raio = 4;
            
            Console.WriteLine(esfera.CalcularVolumeEsfera());
        }
    }
}