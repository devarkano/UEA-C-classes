using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCSharp.POO
{
    public class Evento
    {
        public string Nome { get; set; }
        public List<Contato> Participantes { get; set; }

        public Evento()
        {
            this.Participantes = new List<Contato>();
        }
    }
}
