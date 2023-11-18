using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCSharp.POO
{
    class Pessoa
    {
        private string _nome; // Atributo privado

        public string Nome   // Propriedade
        {
            get { return _nome; }
            set { _nome = value; }
        }
    }


}
