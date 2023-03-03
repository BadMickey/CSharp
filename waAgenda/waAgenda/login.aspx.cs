using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace waAgenda
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogar_Click(object sender, EventArgs e)
        {
            String email = txtEmail.Text;
            String senha = TxtSenha.Text;

            System.Configuration.Configuration rootWebConfig = System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration("/MyWebSiteRoot");
            System.Configuration.ConnectionStringSettings connString;
            connString = rootWebConfig.ConnectionStrings.ConnectionStrings["ConnectionString"];
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connString.ToString();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from usuario where email = @email and senha = @senha";
            cmd.Parameters.AddWithValue("email", txtEmail.Text);
            cmd.Parameters.AddWithValue("senha", TxtSenha.Text);
            con.Open();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                //cookies
                HttpCookie login = new HttpCookie("login", txtEmail.Text);
                Response.Cookies.Add(login);
                //direcionar a página principal
                Response.Redirect("~/index.aspx");
            }
            else
            {
                Response.Write("<script> alert('Error', 'E-mail ou senha incorretos!!!');</script>");
                //txtmsg.Text = "Email e senha podem estar errados ou você não criou uma conta";
            }
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/registrar.aspx");
        }
    }
}