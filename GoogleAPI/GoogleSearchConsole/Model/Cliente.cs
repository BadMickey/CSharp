using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleSearchConsole.Model
{
    public class Cliente
    {
        public int? cont_id { get; set; }
        public bool cont_usa_grades { get; set; }
        public bool cont_usa_cores { get; set; }
        public int? cont_casas_decimais { get; set; }
        public string cont_nome_fantasia { get; set; }
        public string cont_razao_social { get; set; }
        public string cont_endereco { get; set; }
        public string cont_numero { get; set; }
        public string cont_bairro { get; set; }
        public string cont_cep { get; set; }
        public string cont_cidade { get; set; }
        public string cont_uf { get; set; }
        public string cont_cnpj_cpf { get; set; }
        public double? cont_limite_credito { get; set; }
        public string cont_codigo { get; set; }
        public string cont_status { get; set; }
        public string cont_tipo { get; set; }
        public string cont_pessoa { get; set; }
        public string cont_id_externo { get; set; }
        public string cont_origem { get; set; }
        public int? ys_cola_id { get; set; }
        public DateTime? ys_datahora { get; set; }
        public DateTime ys_datahora_insercao { get; set; }
        public int? excluido { get; set; }
    }
}
