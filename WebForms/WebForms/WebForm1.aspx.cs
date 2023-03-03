using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void btnMostrarMensagem_Click(object sender, EventArgs e)
        {
            Response.Write("Olá " + txtMensagem.Text);
            Response.Write("<script>alert('Olá " + txtMensagem.Text + "')</script");
        }

        protected void txtMensagem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}