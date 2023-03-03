using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace waAgenda
{
    public partial class usuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Inserted(object sender, SqlDataSourceStatusEventArgs e)
        {
            if (e.Exception !=null)
            {
                Response.Write("<script> alert('Inserindo um registro duplicado ou com campos em branco');</script>");
                e.ExceptionHandled= true;
            }
        }

        protected void Updated(object sender, SqlDataSourceStatusEventArgs e)
        {
            Response.Write("<script> alert('Alterando um registro sem informar todos os campos');</script>");
            e.ExceptionHandled = true;
        }
    }
}