namespace ListaExercicios05.Exercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NotaHarmonica nota = new NotaHarmonica();
            nota.nota1 = 7;
            nota.nota2 = 6;
            nota.nota3 = 5;
            Console.WriteLine(nota.CalcularNotaHarmonica());
        }
    }
}