using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms
{
    public partial class Cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private void mostrarLista()
        {
            pnlCadastro.Visible = false;
            pnlResultado.Visible = true;

            GridResultado.DataSource = Usuario.Lista;
        }
    }
}