namespace ListaExercicios05.Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Temperatura temperatura = new Temperatura();
            temperatura.temperaturaF =90;

            Console.WriteLine(temperatura.ConversaoTemperaturaParaCelsius());
            

        }
    }
}