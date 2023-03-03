using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace waAgenda
{
    public partial class contatos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEmail.Text != "" && txtNome.Text != "" && txtTelefone.Text != "")
                {
                    System.Configuration.Configuration rootWebConfig = System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration("/MyWebSiteRoot");
                    System.Configuration.ConnectionStringSettings connString;
                    connString = rootWebConfig.ConnectionStrings.ConnectionStrings["ConnectionString"];
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = connString.ToString();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "Insert into Contato (nome, email, Telefone) values (@nome,@email,@Telefone)";
                    cmd.Parameters.AddWithValue("nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("Telefone", txtTelefone.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    GridView1.DataBind();
                }
                else
                {
                    throw new Exception("Existem campos em branco");
                }
            }
            catch (Exception erro)
            {
                Response.Write("<script> alert('" + erro.Message + "'); </script>");
            }
        }
    }
}