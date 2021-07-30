using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExemploCRUD
{
    public partial class Consultar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        Fabricante fabricante = new Fabricante();
        FabricanteDAL fabricanteDAL = new FabricanteDAL();
        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                fabricante.Nome = txtBusca.Text;
                gvResultado.DataSource = fabricanteDAL.Consultar(fabricante);
                gvResultado.DataBind();
                lblStatus.Text = "Funcionou </br>";
            }
            catch (Exception erro)
            {
                lblStatus.Text = "Oops... <br/>" + erro.Message;
            }
        }
    }
}