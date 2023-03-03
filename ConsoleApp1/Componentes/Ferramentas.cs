using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Componentes
{
    public class Ferramentas
    {
        internal string MetodoSomenteParaMeuAssembly()
        {
            return "Este método é somente acessado dentro do Assembly componentes";
        }

        public string MetodosParaTodos()
        {
            return "Este método é para todos";
        }

        public bool ValidarCPF(string CPF)
        {
            return true;
        }
    }
}
