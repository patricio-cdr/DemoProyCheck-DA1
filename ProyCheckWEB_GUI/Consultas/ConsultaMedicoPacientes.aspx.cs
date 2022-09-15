using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyCheck_BL;
using ProyCheck_BE;

namespace ProyCheckWEB_GUI.Consultas
{
    public partial class ConsultaMedicoPacientes : System.Web.UI.Page
    {
        MedicoBL objMedicoBL = new MedicoBL();
        MedicoBE objMedicoBE = new MedicoBE();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                btnConsultar.Enabled = false;
                btnConsultar.BackColor = System.Drawing.Color.LightSlateGray;
            }
        }

        protected void btnBuscar_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                objMedicoBE = objMedicoBL.ConsultarMedico(txtCodigo.Text.Trim());
                if (objMedicoBE.CodMedico == null)
                {
                    txtNombre.Text = "";
                    txtApellido.Text = "";
                    txtDni.Text = "";
                    txtEspecialidad.Text = "";
                    txtUbigeo.Text = "";
                    txtDireccion.Text = "";
                    txtEstado.Text = "";
                    lblRegistro.Text = "";
                    txtFechInicio.Text = "";

                    btnConsultar.Enabled = false;
                    btnConsultar.BackColor = System.Drawing.Color.LightSlateGray;
                    lblMensaje.Text = "Medico no existe";
                    mpMensaje.Show();
                }
                else
                {
                    txtNombre.Text = objMedicoBE.NomMedico;
                    txtApellido.Text = objMedicoBE.ApeMedico;
                    txtDni.Text = objMedicoBE.DniMedic;
                    txtEspecialidad.Text = objMedicoBE.NomEspecialidad;
                    txtUbigeo.Text = objMedicoBE.NomUbigeo;
                    txtDireccion.Text = objMedicoBE.DirecMedico;
                    txtEstado.Text = objMedicoBE.DescEstado;

                    btnConsultar.Enabled = true;
                    btnConsultar.BackColor = System.Drawing.Color.LightSkyBlue;
                    //lblRegistro.Text = "";
                }
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error: " + ex.Message;
                mpMensaje.Show();
            }
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                grvPacienteAtendido.DataSource = objMedicoBL.ListarPacientesxMedico(txtCodigo.Text.Trim(), Convert.ToDateTime(txtFechInicio.Text.Trim()));
                grvPacienteAtendido.DataBind();
                lblRegistro.Text = "Cantidad de pacientes atendidos a partir de la fecha: " + grvPacienteAtendido.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error: " + ex.Message;
                mpMensaje.Show();
            }
        }
    }
}