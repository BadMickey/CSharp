using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebForms
{
    public class Usuario
    {
        public Usuario() { }
           
        public string Nome { get; set; }
        public string Telefone { get; set; }

        private static List<Usuario> Lista = new List<Usuario>();

        public List<Usuario> Todos()
        {
            return Usuario. Lista;
        }

        public void Salvar()
        {
            Usuario.Lista.Add(this);
        }
    }
}