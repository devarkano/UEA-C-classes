using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCSharp.POO.Construtor
{
    class Pessoa
    {
        public Pessoa() { /* Construtor padrão */ }
        public Pessoa(string nome) { /* Construtor sobrecarregado */ }
        public Pessoa(string nome, int idade) => (Nome, Idade) = (nome, idade);
        public string Nome { get; }
        public int Idade { get; }
    }
}
