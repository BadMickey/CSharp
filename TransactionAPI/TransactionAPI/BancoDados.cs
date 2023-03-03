using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace TransactionAPI
{
    public class BancoDados
    {
        public NpgsqlConnection conn { get; set; }

        public BancoDados()
        {
            conn = new NpgsqlConnection(System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"]);
        }

        public void ExecutarSQL(string SQL)
        {
            ExecutarSQL(SQL, null);
        }
        public void ExecutarSQL(string SQL, List<NpgsqlParameter> Parametros)
        {
            NpgsqlCommand cmd = new NpgsqlCommand(SQL, conn);
            if (Parametros != null)
            {
                foreach (NpgsqlParameter param in Parametros)
                    cmd.Parameters.Add(param);
            }
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public DataTable ObterDataTable(string SQL)
        {
            return ObterDataTable(SQL, null);
        }

        public DataTable ObterDataTable(string SQL, List<NpgsqlParameter> Parametros)
        {
            NpgsqlCommand cmd = new NpgsqlCommand(SQL, conn);

            if (Parametros != null)
            {
                foreach (NpgsqlParameter param in Parametros)
                {
                    cmd.Parameters.Add(param);
                }
            }

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);

            DataTable tabela = new DataTable();
            da.Fill(tabela);
            return tabela;
        }

        public int ObterInteiro(string SQL)
        {
            DataTable tabela = ObterDataTable(SQL);
            int valor = Convert.ToInt32(tabela.Rows[0][0]);

            return valor;
        }
    }

    public class BancoPostgre
    {
        public NpgsqlConnection conn { get; set; }
        public string SQL { get; set; }
        private List<NpgsqlParameter> Parametros = new List<NpgsqlParameter>();
        private NpgsqlTransaction transaction = null;

        public BancoPostgre()
        {
            conn = new NpgsqlConnection(System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"]);
            conn.Open();
        }
        public BancoPostgre(string StringConexao)
        {
            conn = new NpgsqlConnection(StringConexao);
        }

        public void Dispose()
        {
            conn.Close();
        }

        public void AddParametros(string Chave, object Valor)
        {
            Parametros.Add(new NpgsqlParameter(Chave, Valor));
        }

        public void Begin()
        {
            transaction = conn.BeginTransaction();
        }

        public void Commit()
        {
            transaction.Commit();
        }

        public void Rollback()
        {
            transaction.Rollback();
        }

        public void ExecutarSQL()
        {
            NpgsqlCommand cmd = new NpgsqlCommand(SQL, conn, transaction);
            if (Parametros != null)
            {
                foreach (NpgsqlParameter param in Parametros)
                    cmd.Parameters.Add(param);
            }
            cmd.ExecuteNonQuery();

            Parametros.Clear();

        }

        public DataTable ObterDataTable()
        {
            NpgsqlCommand cmd = new NpgsqlCommand(SQL, conn);

            if (Parametros != null)
            {
                foreach (NpgsqlParameter param in Parametros)
                {
                    cmd.Parameters.Add(param);
                }
            }

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);

            DataTable tabela = new DataTable();
            da.Fill(tabela);

            Parametros.Clear();

            return tabela;
        }

    }
}