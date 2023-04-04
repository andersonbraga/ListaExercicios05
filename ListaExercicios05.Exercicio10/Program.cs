namespace ListaExercicios05.Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NotaPonderada nota = new NotaPonderada();
            nota.nota1 = 7;
            nota.nota2 = 6;
            nota.nota3 = 5;
            Console.WriteLine(nota.CalcularNotaPonderada());
        }
    }
}