using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCSharp
{
    internal class Exercicio_For
    {
        public static void Run()
        {
            Console.Write("Qual tabuada vc quer:");
            int numero = int.Parse(Console.ReadLine());

            int somaTotal = 0;
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"- {numero} x {i} = {numero*i}");

                somaTotal += numero * i;
            }

            Console.WriteLine($"Soma total {somaTotal}");
        }
    }
}
