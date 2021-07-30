using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExemploCRUD
{
    public partial class Atualizar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            txtCod.Text = "";
            txtNome.Text = "";
            txtNome.Focus();
        }


        Fabricante fabricante = new Fabricante();
        FabricanteDAL fabricanteDAL = new FabricanteDAL();

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtCod.Text == "" || txtNome.Text.Length < 3)
            {
                lblStatus.Text = "Informe todos os campos!";

            }
            else {

                try
                {

                    fabricante.ID = int.Parse(txtCod.Text);
                    fabricante.Nome = txtNome.Text;
                    fabricanteDAL.Atualizar(fabricante);
                    Server.Transfer("Consultar.aspx");
                }
                catch (Exception erro)
                {
                    lblStatus.Text = "Ops... <br/>" + erro.Message; 
                    
                }
            
            }
        }
    }
}