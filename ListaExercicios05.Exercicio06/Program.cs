namespace ListaExercicios05.Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TemperaturaCelsius temperatura = new TemperaturaCelsius();
            temperatura.temperaturaC = 50;
            Console.WriteLine(temperatura.ConverterTemperaturaParaF());
        }
    }
}