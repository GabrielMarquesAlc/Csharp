using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExemploCRUD
{
    public partial class Cadastrar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            Fabricante fabricante = new Fabricante();
            fabricante.Nome = txtFabricante.Text;

            FabricanteDAL fabricanteDAL = new FabricanteDAL();
            try
            {
                fabricanteDAL.Cadastrar(fabricante);
                lblStatus.Text = "Cadastro efetuado!";
                txtFabricante.Text = "";
                txtFabricante.Focus();
            }
            catch (Exception erro)
            {
                lblStatus.Text = "Oooops.. <br/>" + erro.Message;
            }
        }
    }
}