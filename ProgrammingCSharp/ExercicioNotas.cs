using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCSharp
{
    internal class ExercicioNotas
    {
        public static void Run()
        {
            Console.Write($"Quantos alunos tem na sala ?");
            int totalAlunos = int.Parse(Console.ReadLine());

            string[] alunos = new string[totalAlunos];
            float[] notas = new float[totalAlunos];

            int melhorAlunoIdx = 0;

            for (int i = 0; i < totalAlunos; i++)
            {
                Console.Write($"Informe o nome do aluno (N {i + 1}):");
                alunos[i] = Console.ReadLine();
    
                Console.Write($"Informe a nota:");
                notas[i] = int.Parse(Console.ReadLine());

                if (notas[i] > notas[melhorAlunoIdx])
                {
                    melhorAlunoIdx = i;
                }
            }

            for (int i = 0; i < totalAlunos; i++)
            {
                if (i == melhorAlunoIdx)
                {
                    Console.WriteLine($"{i + 1} - TOPTOP {alunos[i]}, Nota: {notas[i]} ");
                }
                else
                {
                    Console.WriteLine($"{i + 1} - {alunos[i]}, Nota: {notas[i]} ");
                }

            }

        }

    }
}
