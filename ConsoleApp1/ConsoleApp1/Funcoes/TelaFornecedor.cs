using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcoes
{
    class TelaFornecedor
    {
        public static void Chamar()
        {

            Console.WriteLine("----------------------- Cadastro de Fornecedors -----------------------\n");

            while (true)
            {
                string mensagem = "Digite uma das opções abaixo:" +
                   "\n       0 - Sair do cadastro" +
                   "\n       1 - Para cadastrar Fornecedores" +
                   "\n       2 - Para listar Fornecedores";
                Console.WriteLine(mensagem);


                int valor = int.Parse(Console.ReadLine());

                if (valor == 0)
                {
                    break;
                }
                else if (valor == 1)
                {
                    var fornecedor = new Fornecedor();

                    Console.WriteLine("Digite o CNPJ do Fornecedor");
                    fornecedor.CNPJ = Console.ReadLine();

                    Console.WriteLine("Digite o nome do Fornecedor");
                    fornecedor.Nome = Console.ReadLine();

                    Console.WriteLine("Digite o telefone do Fornecedor");
                    fornecedor.Telefone = Console.ReadLine();

                    Console.WriteLine("Digite o CPF do gerente");
                    fornecedor.CPF = Console.ReadLine();

                    fornecedor.Gravar();
                }
                else if (valor == 2)
                {
                    var Fornecedores = new Fornecedor().Ler();
                    foreach (Fornecedor us in Fornecedores)
                    {
                        Console.WriteLine("---------------------------");
                        Console.WriteLine(us.CNPJ);
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
