using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCSharp
{
    internal class ExLinkedList
    {
        public static void Run()
        {
            LinkedList<string> meses = new LinkedList<string>();
            
            meses.AddLast("Março");
            meses.AddFirst("Janeiro");
            
            var marco = meses.Find("Março");
            meses.AddBefore(marco, "Fevereiro");
            meses.AddAfter(marco, "Abril");

            var node = new LinkedListNode<string>("Maio");
            meses.AddLast(node);
            
            foreach (string mes in meses)
            {
                Console.WriteLine(mes);
            }
        }
    }
}
