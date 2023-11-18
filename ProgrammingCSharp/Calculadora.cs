using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCSharp
{
    internal class Calculadora
    {
        public static void Run()
        {
            Console.WriteLine("- soma");
            Console.WriteLine("- produto");
            Console.WriteLine("- subtracao");
            Console.WriteLine("- divisao");
            Console.Write("Escolha uma operação aritimetica:");

            string op = Console.ReadLine().ToLower();

            Console.Write("Informe o valor de A:");
            int valorA = int.Parse(Console.ReadLine());

            Console.Write("Informe o valor de B:");
            int valorB = int.Parse(Console.ReadLine());

            switch (op)
            {
                case "soma":
                    Console.WriteLine($"A soma de {valorA} e {valorB} é {valorA + valorB}");
                    break;

                case "subtracao":
                    Console.WriteLine("???");
                    break;

                default:
                    Console.WriteLine("Não entendi");
                    break;
            }
        }
    }
}
