using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Estado
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public override string ToString()
        {
            return this.Nome;
        }
        public static List<Estado> Lista()
        {
            var lista = new List<Estado>();
            var e1 = new Estado();
            e1.Id = 1;
            e1.Nome = "SP";
            lista.Add(e1);

            var e2 = new Estado();
            e2.Id = 2;
            e2.Nome = "RJ";
            lista.Add(e2);

            var e3 = new Estado();
            e3.Id = 3;
            e3.Nome = "SC";
            lista.Add(e3);

            var e4 = new Estado();
            e4.Id = 4;
            e4.Nome = "GO";
            lista.Add(e4);
            return lista;
        }
    }
}
