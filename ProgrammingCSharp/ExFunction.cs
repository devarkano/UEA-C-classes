using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCSharp
{

    internal class ExFunction
    {
        public static void Run()
        {
            Random rnd = new Random();
            int a = rnd.Next() % 100;
            int b = rnd.Next() % 50;

            Console.WriteLine($"A:{a}, B:{b},  AxB:{Calcular(TipoOperacao.Multiplica, a, b)}");
        }

        public static double Calcular(TipoOperacao _op, int a, int b)
        {
            double resultado = 0;

            double Adicionar(double a, double b) { return (a + b); }
            double Subtrair(double a, double b) { return (a - b); }
            double Multiplicar(double a, double b) { return (a * b); }
            double Dividir(double a, double b) { return (a / b); }

            TipoOperacao op = TipoOperacao.Multiplica;

            switch (op)
            {
                case TipoOperacao.Multiplica:
                    resultado = Multiplicar(a, b);
                    break;
                case TipoOperacao.Soma:
                    break;
                case TipoOperacao.Divide:
                    break;
                case TipoOperacao.Subtrai:
                    break;
                default:
                    break;
            }


            return resultado;
        }
    }
}
