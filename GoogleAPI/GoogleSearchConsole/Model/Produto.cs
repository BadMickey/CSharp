using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleSearchConsole.Model
{
    public class Produto
    {
        public int? prod_id { get; set; }
        public int? prod_cont_id { get; set; }
        public double? prod_estoque_minimo { get; set; }
        public double? prod_preco { get; set; }
        public double? prod_promocao { get; set; }
        public double? prod_peso { get; set; }
        public double? prod_peso_liquido { get; set; }
        public double? prod_altura { get; set; }
        public double? prod_comprimento { get; set; }
        public double? prod_largura { get; set; }
        public double? prod_ipi { get; set; }
        public string prod_codigo { get; set; }
        public string prod_descricao { get; set; }
        public string prod_status { get; set; }
        public double? prod_estoque { get; set; }
        public double? prod_espessura { get; set; }
        public string prod_origem { get; set; }
        public int? ys_cola_id { get; set; }
        public DateTime? ys_datahora { get; set; }
        public DateTime? ys_datahora_insercao { get; set; }
        public DateTime? ys_datahora_atualizacao { get; set; }
        public int? excluido { get; set; }
    }


}
