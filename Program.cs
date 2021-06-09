using Dominio;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var empregado1 = new Analista("Julio", 15000);
            Console.WriteLine($"Nome: {empregado1.Nome}");
            Console.WriteLine($"Salário: {empregado1.Salario:N2}");
            Console.WriteLine($"Salário bonificado: {empregado1.CalcularSalarioBonificado():N2}");

            var empregado2 = new Vendedor("Julio Analista", 15000);
            Console.WriteLine($"Nome: {empregado2.Nome}");
            Console.WriteLine($"Salário: {empregado2.Salario:N2}");
            Console.WriteLine($"Salário bonificado: {empregado2.CalcularSalarioBonificado():N2}");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"{empregado1.ToString()}");
            Console.WriteLine($"{empregado2.ToString()}");


        }
    }
}
