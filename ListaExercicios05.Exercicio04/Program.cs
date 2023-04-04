namespace ListaExercicios05.Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsumoCombustivel consumoCombustivel = new ConsumoCombustivel();
            consumoCombustivel.kmInicial = 150;
            consumoCombustivel.kmFinal = 500;
            Console.WriteLine(consumoCombustivel.CalcularConsumoCombustivel());
        }
    }
}