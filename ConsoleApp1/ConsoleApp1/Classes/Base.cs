﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public abstract class Base : IPessoa
    {
        public string Nome;
        public string Telefone;
        public string CPF;
        private string sobrenome = "souza";

        public Base(string nome, string telefone, string cpf)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.CPF = cpf;
        }
         
        public Base() { }

        public void SetNome(string nome) { this.Nome = nome; }
        public void SetTelefone(string telefone) { this.Telefone = telefone; }
        public void SetCPF(string cpf) { this.CPF = cpf; }
        public virtual void Gravar()
        {
            var dados = this.Ler();
            dados.Add(this);

            StreamWriter r = new StreamWriter(diretorioComArquivos());
            r.WriteLine("nome;telefone;cpf");
            foreach (Base b in dados)
            {
                var linha = b.Nome + ";" + b.Telefone + ";" + b.CPF + ";";
                r.WriteLine(linha);
            }
            r.Close();

        }
        internal string diretorioComArquivos()
        {
            return ConfigurationManager.AppSettings["CaminhoArquivos"] + this.GetType().Name + ".txt";
        }
        public virtual List<IPessoa> Ler()
        {
            var dados = new List<IPessoa>();
            if (File.Exists(diretorioComArquivos()))
            {
                using (StreamReader arquivo = File.OpenText(diretorioComArquivos()))
                {
                    string linha;
                    int i = 0;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        i++;
                        if (i == 1) continue;
                        var baseArquivo = linha.Split(';');

                        var b = (IPessoa)Activator.CreateInstance(this.GetType());
                        b.SetNome(baseArquivo[0]);
                        b.SetTelefone(baseArquivo[1]);
                        b.SetCPF(baseArquivo[2]);
                        dados.Add(b);
                    }
                }
            }
            return dados;
        }
        public virtual void Olhar()
        {
            Console.WriteLine("O cliente " + this.Nome + " " + this.sobrenome + " está olhando para mim");
        }

        protected int CalculaUmMaisDois()
        {
            return 1 + 2;
        }

        public int CalculaUmMaisDois2()
        {
            return 1 + 2;
        }

        public int CalculaUmMaisDois3()
        {
            return 1 + 2;
        }

        internal int CalculaUmMaisDois4()
        {
            return 1 + 2;
        }
    }
}
