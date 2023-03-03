using Calculo;
using Diretorio;
using Funcoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tela
{
    class Menu
    {
        public const int SAIDA_PROGRAMA = 0;
        public const int LER_ARQUIVOS = 1;
        public const int TABUADA = 2;
        public const int CALCULO_MEDIA = 3;
        public const int CADASTRAR_CLIENTES = 4;
        public const int CADASTRAR_USUARIOS = 5;
        public const int CADASTRAR_FORNECEDORES = 6;

        public static void Criar()
        {
            while (true)
            {
                string mensagem = "Olá usuário, utilizando o programa\n" +
                    "\n Aplicação Console final" +
                    "\n\n" +
                    "\n     Digite uma das opções abaixo:" +
                    "\n       0 - para sair do programa" +
                    "\n       1 - para ler arquivos" +
                    "\n       2 - para executar tabuada" +
                    "\n       3 - Calcular média de alunos" +
                    "\n       4 - Cadastrar clientes" +
                    "\n       5 - Cadastrar Usuarios" +
                    "\n       6 - Cadastrar Fornecedores";
                Console.WriteLine(mensagem);

                int valor = int.Parse(Console.ReadLine());

                if (valor == SAIDA_PROGRAMA)
                {
                    break;
                }
                else if (valor == LER_ARQUIVOS)
                {
                    Console.WriteLine("----------------------- Opção ler arquivos -----------------------");
                    Arquivo.LerArquivo(1);
                    Console.WriteLine("\n------------------------------------------------------------------\n");

                }
                else if (valor == TABUADA)
                {
                    Console.WriteLine("----------------------- Opção tabuada -----------------------");
                    Console.WriteLine("Digite o número da tabuada: ");
                    int numero = int.Parse(Console.ReadLine());
                    Console.WriteLine("\n-------------------------------------------------------------\n");
                    Tabuada.Calcular(numero);

                }
                else if (valor == CALCULO_MEDIA)
                {
                    Media.Aluno();
                    Console.WriteLine("\n-------------------------------------------------------------\n");

                }
                else if (valor == CADASTRAR_CLIENTES)
                {
                    TelaCliente.Chamar();
                    Console.WriteLine("\n-------------------------------------------------------------\n");

                }
                else if (valor == CADASTRAR_USUARIOS)
                {
                    TelaUsuario.Chamar();
                    Console.WriteLine("\n-------------------------------------------------------------\n");

                }
                else if (valor == CADASTRAR_FORNECEDORES)
                {
                    TelaFornecedor.Chamar();
                    Console.WriteLine("\n-------------------------------------------------------------\n");

                }
                else
                {
                    Console.WriteLine("Opção inválida, tente novamente");
                }
            }
        }
    }
}
