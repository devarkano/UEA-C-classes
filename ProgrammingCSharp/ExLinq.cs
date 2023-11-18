using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCSharp
{
    internal class ExLinq
    {
        public static void Run()
        {
            List<string> numeros = new List<string>();

            numeros.Add("UM");
            numeros.Add("dois");
            numeros.Add("três");
            numeros.Add("quatro");
            numeros.Add("cinco");

            var found = numeros
                .Where(num => num.Equals("QUATRO", StringComparison.OrdinalIgnoreCase))
                .SingleOrDefault();

            Console.WriteLine($"Found: {found}");

            Random rnd = new Random();
            List<int> randomValues = 
                Enumerable.Range(0, 100)
                .Select(o => rnd.Next() % 100)
                .ToList();

            Console.WriteLine($"Count: {randomValues.Count()}, Average: {randomValues.Average()}, Sum: {randomValues.Sum()}");
            Console.WriteLine($"Min: {randomValues.Min()}, Max: {randomValues.Max()}");

            var ordered = randomValues.OrderBy(o => o).ToList();

            var descendingOrder = randomValues.OrderByDescending(o => o).ToList();

            Console.WriteLine();
        }
    }
}
