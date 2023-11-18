using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCSharp
{
    internal class ExecicioQueue
    {
        public static void Run()
        {
            // Criando uma fila de inteiros
            Queue<int> minhaFila = new Queue<int>();

            // Enfileirando alguns números
            minhaFila.Enqueue(1);
            minhaFila.Enqueue(2);
            minhaFila.Enqueue(3);

            // Desenfileirando e exibindo os elementos
            while (minhaFila.Count > 0)
            {
                int elemento = minhaFila.Dequeue();
                Console.WriteLine($"Elemento desenfileirado: {elemento}");
            }
        }
    }
}
