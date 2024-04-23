using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro valor:");
            double valor1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor");
            double valor2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o terceiro vaor");
            double valor3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o quarto valor");
            double valor4 = Convert.ToDouble(Console.ReadLine());

            double media = (valor1 + valor2 + valor3 + valor4) / 4;

            Console.WriteLine($"A media aritmetica dos valores {valor1}, {valor2}, {valor3} e {valor4} é: {media}");

        }
    }
}
