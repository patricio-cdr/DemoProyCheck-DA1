using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyCheck_BL;

namespace ProyCheckWEB_GUI.consultas
{
    public partial class ConsultaAnalisisEstado : System.Web.UI.Page
    {
        AnalisisBL objAnalisisBL = new AnalisisBL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                CargarDatos();
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error: " + ex.Message;
            }
        }

        protected void grvAnalisis_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grvAnalisis.PageIndex = e.NewPageIndex;
            CargarDatos();
        }

        private void CargarDatos()
        {
            if (cboPacientes.SelectedValue.ToString() == "Todos")
            {
                grvAnalisis.DataSource = objAnalisisBL.ListarAnalisis();
                grvAnalisis.DataBind();
            }
            else
            {
                grvAnalisis.DataSource = objAnalisisBL.ConsultarAnalisis(cboPacientes.SelectedValue.ToString());
                grvAnalisis.DataBind();
            }
        }
    }
}