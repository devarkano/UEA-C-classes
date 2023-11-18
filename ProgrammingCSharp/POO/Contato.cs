using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCSharp.POO
{
    public class Contato
    {
        public string Nome { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public bool Ativo { get; set; }

        public Contato()
        {
            Ativo = true;   
        }
    }
}
