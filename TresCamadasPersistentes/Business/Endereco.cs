using Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Endereco : Base
    {
        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string Logradouro { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string Numero { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string Cidade { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string Estado { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true, ChavePrimaria = true)]
        public string CPF { get; set; }
    }
}
