using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diretorio
{   
    class Arquivo
    {
        private static string caminhoArquivo()
        {
            return ConfigurationManager.AppSettings["CaminhoArquivos"];
        }

        public static void LerArquivo(int numeroArquivo)
        {
            string arquivoCaminho = caminhoArquivo() + "arq" + numeroArquivo + ".txt";
            Console.WriteLine("----------------------- Lendo arquivo ----------------------- ");
            if (File.Exists(arquivoCaminho))
            {
                using (StreamReader arquivo = File.OpenText(arquivoCaminho))
                {
                    string linha;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        Console.WriteLine(linha);
                    }
                }
            }
            string arquivoCaminho2 = caminhoArquivo() + "arq" + (numeroArquivo + 1) + ".txt";

            if (File.Exists(arquivoCaminho2)) 
            {
                LerArquivo(numeroArquivo + 1);
            }
        }
    }
}
