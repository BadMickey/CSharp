﻿using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcoes
{
    class TelaCliente
    {
        public static void Chamar()
        {

            Console.WriteLine("----------------------- Cadastro de Clientes -----------------------\n");

            while (true)
            {
                string mensagem = "Digite uma das opções abaixo:" +
                   "\n       0 - Sair do cadastro" +
                   "\n       1 - Para cadastrar clientes" +
                   "\n       2 - Para listar clientes";
                Console.WriteLine(mensagem);


                int valor = int.Parse(Console.ReadLine());

                if (valor == 0)
                {
                    break;
                }
                else if (valor == 1)
                {
                    var cliente = new Cliente();

                    Console.WriteLine("Digite o nome do Cliente");
                    cliente.Nome = Console.ReadLine();

                    Console.WriteLine("Digite o telefone do Cliente");
                    cliente.Telefone = Console.ReadLine();

                    Console.WriteLine("Digite o CPF do Cliente");
                    cliente.CPF = Console.ReadLine();

                    cliente.Gravar();
                }
                else if (valor == 2)
                {
                    var clientes = new Cliente().Ler();
                    foreach (Cliente c in clientes)
                    {
                        Console.WriteLine("---------------------------");
                        Console.WriteLine(c.Nome);
                        Console.WriteLine(c.Telefone);
                        Console.WriteLine(c.CPF);
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
