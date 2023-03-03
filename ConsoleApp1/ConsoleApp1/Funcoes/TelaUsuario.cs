using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcoes
{
    class TelaUsuario
    {
        public static void Chamar()
        {

            Console.WriteLine("----------------------- Cadastro de Usuarios -----------------------\n");

            while (true)
            {
                string mensagem = "Digite uma das opções abaixo:" +
                   "\n       0 - Sair do cadastro" +
                   "\n       1 - Para cadastrar Usuarios" +
                   "\n       2 - Para listar Usuarios";
                Console.WriteLine(mensagem);


                int valor = int.Parse(Console.ReadLine());

                if (valor == 0)
                {
                    break;
                }
                else if (valor == 1)
                {
                    var usuario = new Usuario();

                    Console.WriteLine("Digite o nome do Usuario");
                    usuario.Nome = Console.ReadLine();

                    Console.WriteLine("Digite o telefone do Usuario");
                    usuario.Telefone = Console.ReadLine();

                    Console.WriteLine("Digite o CPF do Usuario");
                    usuario.CPF = Console.ReadLine();

                    usuario.Gravar();
                }
                else if (valor == 2)
                {
                    var Usuarios = new Usuario().Ler();
                    foreach (Usuario us in Usuarios)
                    {
                        Console.WriteLine("---------------------------");
                        Console.WriteLine(us.Nome);
                        Console.WriteLine(us.Telefone);
                        Console.WriteLine(us.CPF);
                        Console.WriteLine("---------------------------");
                    }
                }
                else
                {
                    Console.WriteLine("Opção inválida, tente novamente");
                }

            }
        }
    }
}
