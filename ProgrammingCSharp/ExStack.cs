
namespace ProgrammingCSharp
{
    internal class ExStack
    {
        public static void Run()
        {
            Stack<string> numeros = new Stack<string>();
            numeros.Push("Exemplo");
            numeros.Push("de");
            numeros.Push("frase");
            numeros.Push("para");
            numeros.Push("inversão");

            while (numeros.Any())
            {
                Console.WriteLine(numeros.Pop());
            }
        }
    }
}
