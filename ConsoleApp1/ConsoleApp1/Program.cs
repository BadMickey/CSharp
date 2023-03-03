using Classes;
using Componentes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tela;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu.Criar();
        }
    }
}

#region Códigos de teste das aulas de POO
/*
Email.Instancia.Corpo = "corpo";
Email.Instancia.Titulo = "Titulo";
Email.Instancia.Origem = "origem";
Email.Instancia.Destino = "destino";

Email.Instancia.EnviarEmail();

var a = new Animal();
a.teste = "";

var c = new Cachorro();
c.Idade = 1;
Console.WriteLine(c.Idade);

c.Idade2 = 1;
Console.WriteLine(c.Idade2);

var cachorro = new Classes.Cachorro();
cachorro.Latir();
Console.WriteLine("------------------ Cadastro de Clientes ------------------");
Cliente c = new Cliente();
c.Nome = "cliente";
c.Telefone = "33333";
c.CPF = "55555";
c.Gravar();

foreach (Cliente cl in new Cliente().Ler())
{
    Console.WriteLine(cl.Nome);
    Console.WriteLine(cl.Telefone);
    Console.WriteLine(cl.CPF);
    Console.WriteLine("-------------------------------------------------------------");
}

Console.WriteLine("------------------ Cadastro de Usuários ------------------");
Usuario u = new Usuario();
u.Nome = "Usuario";
u.Telefone = "33333";
u.CPF = "55555";
u.Gravar();

foreach(Usuario  us in new Usuario().Ler())
{
    Console.WriteLine(us.Nome);
    Console.WriteLine(us.Telefone);
    Console.WriteLine(us.CPF);
    Console.WriteLine("-------------------------------------------------------------");
}
Console.ReadLine();

/*Ferramentas f = new Ferramentas();
bool d = f.ValidarCPF("sdds");

class Animal
{
    public string Teste;
    public virtual string Teste2()
    {
        return "";
    }
}

class Macaco : Animal
{
    public override string Teste2()
    {
        return "sss";
    }
}
partial class Animal
{
    public string teste;
    partial void tt();
}
partial class Animal
{
    public string teste2;   
    partial void tt()
    {
        Console.WriteLine("teste");
    }
}*/
#endregion