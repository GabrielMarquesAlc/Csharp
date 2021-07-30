using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExemploCRUD
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            Server.Transfer("Cadastrar.aspx");
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            Server.Transfer("Consultar.aspx");
        }

        protected void btnAtualizar_Click(object sender, EventArgs e)
        {
            Server.Transfer("Atualizar.aspx");
        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            Server.Transfer("Excluir.aspx");
        }

        protected void btnGoogle_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://www.google.com.br");
        }
    }
}