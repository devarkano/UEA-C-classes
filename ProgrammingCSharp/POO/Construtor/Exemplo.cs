using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCSharp.POO.Construtor
{
    internal class Exemplo
    {
        // Construtor padrão
        public Exemplo()
        {
            // Inicializações e lógica de inicialização aqui
        }

        // Método simples sem parâmetros e sem retorno
        public void MetodoSimples()
        {
            // Lógica do método
        }

        // Método com parâmetros e retorno
        public int Somar(int a, int b)
        {
            return a + b;
        }
    }

    class Exemplo2
    {
        // Construtor padrão é implicitamente criado se não houver construtores definidos
    }
}
