using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCSharp.POO.Interface
{
    interface ILog
    {
        void RegistrarLog(string mensagem);
    }

    class ConsoleLogger : ILog
    {
        public void RegistrarLog(string mensagem) { Console.WriteLine(mensagem); }
    }
}
