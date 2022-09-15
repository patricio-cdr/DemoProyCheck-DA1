using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
// Agregamos 
using ProyCheck_BL;

namespace ProyCheckWEB_GUI.Consultas
{
    public partial class ConsultaPacienteEstado : System.Web.UI.Page
    {
        PacienteBL objPacienteBL = new PacienteBL();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            
            try
            {
                // Limpia el dataGridView y el lblLog
                grvPacEstado.DataSource = null;
                grvPacEstado.DataBind();
                lblLog.Text = "";
                lblMensaje.Text = "";

                Int16 limInf = Convert.ToInt16(txtMayorIgual.Text.Trim());
                String tipo = cboTipoPac.SelectedValue.ToString();
                DataTable dt;

                if (tipo == "Todos")
                {
                    dt = objPacienteBL.ConsultarPacientesXEvaluaciones("%%", limInf);
                    VerificarDataTable(dt);
                }
                else
                {
                    dt = objPacienteBL.ConsultarPacientesXEvaluaciones(tipo, limInf);
                    VerificarDataTable(dt);
                }
                
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error: " + ex.Message;
            }
        }

        public void VerificarDataTable(DataTable dt)
        {
            if (dt.Rows.Count == 0)
            {
                lblLog.Text = "No se encontraron registros con esos parametros.";
            }
            else
            {
                grvPacEstado.DataSource = dt;
                grvPacEstado.DataBind();
            }
        }
    }
}