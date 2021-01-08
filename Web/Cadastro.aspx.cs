using Business;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class Cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGravar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alert", "alert('Preencha o nome');", true);
                return;
            }

            if (string.IsNullOrEmpty(txtIdade.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alert", "alert('Preencha a idade');", true);
                return;
            }

            GravarCliente();
        }

        private void GravarCliente()
        {
            Negocio business = new Negocio();
            Clientes cliente = new Clientes();

            cliente.Nome = txtNome.Text;
            cliente.Idade = Convert.ToInt32(txtIdade.Text);
            business.GravarCliente(cliente);
        }
    }
}