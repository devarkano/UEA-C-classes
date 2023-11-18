using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCSharp
{
    internal class ExercicioFatoral
    {
        static long CalcularFatorial(int numero)
        {
            long resultado = 1;

            // Calcula o fatorial usando um loop for
            for (int i = 1; i <= numero; i++)
            {
                resultado *= i;
            }

            return resultado;
        }
    }
}
