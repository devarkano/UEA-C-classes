using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCSharp.POO
{
    internal class PlaygroundPOO
    {
        public static Contato CriarContato()
        {
            Console.WriteLine("-- NOVO CONTATO");
            string GetString(string pergunta)
            {
                Console.WriteLine(pergunta);
                return Console.ReadLine();
            }

            return new Contato()
            {
                Nome = GetString("Informe o Nome:"),
                Email = GetString("Informe o Email:"),
                PhoneNumber = GetString("Informe o Numero de telefone:")
            };
        }

        public static void Run()
        {
            List<Contato> contatos = new List<Contato>();

            contatos.Add(CriarContato());

            foreach (var cont in contatos)
            {
                Console.WriteLine($"Nome: {cont.Nome}, Email: {cont.Email}, Num. Telefone: {cont.PhoneNumber}");
            }
        }

        public static void ExecutarAgenda()
        {
            Agenda agenda = new Agenda();

            int GetOpt(string pergunta)
            {
                Console.WriteLine(pergunta);
                return int.Parse(Console.ReadLine());
            }

            StringBuilder options = new StringBuilder();
            options.AppendLine("1 - Adicionar contato");
            options.AppendLine("2 - Listar contatos");
            options.AppendLine("3 - Remover contato");
            options.AppendLine("4 - Adicionar Evento");
            options.AppendLine("5 - Listar Eventos");
            options.AppendLine("0 - Sair");
            options.AppendLine("Escolha a opção:");
            
            int opt = 0;
            while ((opt = GetOpt(options.ToString())) != 0)
            {
                switch (opt)
                {
                    case 1:
                        agenda.AdicionarContato();
                        break;
                    case 2:
                        agenda.ListarContatos();
                        break;
                    case 3:
                        agenda.RemoverContato();
                        break;
                    case 4:
                        agenda.AdicionarEvento();
                        break;
                    case 5:
                        agenda.ListarEventos();
                        break;
                    default:
                        Console.WriteLine("Opção invalida");
                        break;
                }
            }

        }
    }
}
