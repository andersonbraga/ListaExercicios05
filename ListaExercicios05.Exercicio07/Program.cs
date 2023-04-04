namespace ListaExercicios05.Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SalarioVendedor salario = new SalarioVendedor();
            salario.salarioBase = 1400;
            salario.totalVendas = 14;
            salario.percentual = 5;
            Console.WriteLine(salario.CalcularSalarioVendedor());
        }
    }
}