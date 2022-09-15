using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using ProyCheck_BL;
using ProyCheck_BE;

namespace ProyCheckWEB_GUI.Consultas
{
    public partial class WebEmpresaEvaluados : System.Web.UI.Page
    {
        EmpresaBL objEmpresaBL = new EmpresaBL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                try
                {
                    CargarUbigeo("14", "01", "01");
                }

                catch (Exception ex)
                {
                    lblMensaje.Text = "Error: " + ex.Message;
                }
            }
        }

        private void CargarUbigeo(String IdDepa, String IdProv, String IdDist)
        {
            UbigeoBL objUbigeoBL = new UbigeoBL();

            cboDepartamento.DataSource = objUbigeoBL.Ubigeo_Departamentos();
            cboDepartamento.DataValueField = "IdDepa";
            cboDepartamento.DataTextField = "Departamento";
            cboDepartamento.SelectedValue = IdDepa;
            cboDepartamento.DataBind();

            cboProvincia.DataSource = objUbigeoBL.Ubigeo_ProvinciasDepartamento(IdDepa);
            cboProvincia.DataValueField = "IdProv";
            cboProvincia.DataTextField = "Provincia";
            cboProvincia.SelectedValue = IdProv;
            cboProvincia.DataBind();

            cboDistrito.DataSource = objUbigeoBL.Ubigeo_DistritosProvinciaDepartamento(IdDepa, IdProv);
            cboDistrito.DataValueField = "IdDist";
            cboDistrito.DataTextField = "Distrito";
            cboDistrito.SelectedValue = IdDist;
            cboDistrito.DataBind();
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                grvEmpEvaluados.DataSource = objEmpresaBL.ListarEmpresaxUbicacion(cboDepartamento.SelectedItem.ToString(),
                                                                                    cboProvincia.SelectedItem.ToString(),
                                                                                    cboDistrito.SelectedItem.ToString());
                grvEmpEvaluados.DataBind();
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error: " + ex.Message;
            }
        }
    }
}