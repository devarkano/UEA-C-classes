using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCSharp.POO
{
    internal class Agenda
    {
        public List<Contato> Contatos { get; set; }
        public List<Evento> Eventos { get; set; }

        public Agenda()
        {
            Contatos = new List<Contato>();
            Eventos = new List<Evento>();
        }

        public void AdicionarContato()
        {
            string GetString(string pergunta)
            {
                Console.WriteLine(pergunta);
                return Console.ReadLine();
            }

            Contato novoContato = new Contato()
            {
                Nome = GetString("Informe o Nome:"),
                Email = GetString("Informe o Email:"),
                PhoneNumber = GetString("Informe o Numero de telefone:")
            };

            while (this.Contatos.Any(cont => cont.PhoneNumber == novoContato.PhoneNumber))
            {
                novoContato.PhoneNumber = GetString("O contato já existe, informe outro Numero de telefone:");
            }

            this.Contatos.Add(novoContato);
        }

        public void ListarContatos()
        {
            Console.WriteLine();
            foreach (Contato cont in this.Contatos)
            {
                Console.WriteLine($"{this.Contatos.IndexOf(cont) + 1} - Nome: {cont.Nome}, Email: {cont.Email}, Num. Telefone: {cont.PhoneNumber}");
            }

        }

        internal void RemoverContato()
        {
            this.ListarContatos();

            Console.WriteLine("Informe qual contato quer remover: (0 - Sair)");
            int indiceContato = int.Parse(Console.ReadLine());

            if (indiceContato - 1 < 0)
            {
                // Sair
                return;
            }

            if (indiceContato - 1 >= this.Contatos.Count)
            {
                Console.WriteLine("Contato invalido");
                return;
            }

            Contato contatoSelecionado = this.Contatos[indiceContato - 1];

            this.Contatos.Remove(contatoSelecionado);

            // Exiba uma listagem com o contatos cadastrados, e pergunte o indice
            // do contato que deve ser removido

            // foreach (ccontato c; contatos) { lista os contatos }

            // pergunta o indice do contato

            // Metodo para remoção em List
            // this.Contatos.Remove(Contatos[0]);

        }

        public void AdicionarEvento()
        {
            string GetString(string pergunta)
            {
                Console.WriteLine(pergunta);
                return Console.ReadLine();
            }

            Evento novoEvento = new Evento()
            {
                Nome = GetString("Informe o Nome do Evento:"),
            };

            /* Implementem a verificaçao de evento com nome duplicado */
            while (this.Eventos.Any(cont => false))
            {
                novoEvento.Nome = GetString("O Evento já existe, informe outro nome:");
            }

            this.Eventos.Add(novoEvento);
        }

        public void ListarEventos()
        {
            Console.WriteLine();
            for (int i = 0; i < this.Eventos.Count; i++)
            {
                Evento ev = this.Eventos[i];
                Console.WriteLine($"{i + 1} - Nome: {ev.Nome}");
                foreach (Contato part in ev.Participantes)
                {
                    Console.WriteLine($"\t Participante {ev.Participantes.IndexOf(part) + 1} - Nome: {part.Nome}");

                }
            }

            Console.WriteLine("Escolha um evento para adicionar participantes: (0 - Ignorar)");
            int evIdx = int.Parse(Console.ReadLine());

            if (evIdx <= 0)
            {
                // Ignorar
                return;
            }

            if (evIdx >= this.Eventos.Count)
            {
                Console.WriteLine("Evento Invalido.");
            }


            Evento eventoSelecionado = this.Eventos[evIdx];

            if (this.Contatos.Any())
            {
                Console.WriteLine("Selecione o contato:");
                for (int j = 0; j < this.Eventos.Count; j++)
                {
                    Contato cont = this.Contatos[j];
                    Console.WriteLine($"{j + 1} - Nome: {cont.Nome}, Email: {cont.Email}, Num. Telefone: {cont.PhoneNumber}");
                }

                Console.WriteLine($"Escolha um contato para adicionar ao evento {eventoSelecionado.Nome}: (0 - Ignorar)");
                int contIdx = int.Parse(Console.ReadLine());

                if (contIdx <= 0)
                {
                    // Ignorar
                    return;
                }

                if (contIdx >= this.Contatos.Count)
                {
                    Console.WriteLine("Contato Invalido.");
                }

                Contato contatoSelecionado = this.Contatos[contIdx];

                eventoSelecionado.Participantes.Add(contatoSelecionado);
            }
        }
    }
}
