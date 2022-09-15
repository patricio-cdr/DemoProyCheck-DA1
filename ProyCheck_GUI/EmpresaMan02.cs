using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ProyCheck_BL;
using ProyCheck_BE;

namespace ProyCheck_GUI
{
    public partial class EmpresaMan02 : Form
    {
        EmpresaBL objEmpresaBL = new EmpresaBL();
        EmpresaBE objEmpresaBE = new EmpresaBE();

        public EmpresaMan02()
        {
            InitializeComponent();
        }

        private void EmpresaMan02_Load(object sender, EventArgs e)
        {
            try
            {
                CargarUbigeo("14", "01", "01");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);

            }

        }

        private void CargarUbigeo(String IdDepa, String IdProv, String IdDist)
        {
            UbigeoBL objUbigeoBL = new UbigeoBL();

            cboDepartamento.DataSource = objUbigeoBL.Ubigeo_Departamentos();
            cboDepartamento.ValueMember = "IdDepa";
            cboDepartamento.DisplayMember = "Departamento";
            cboDepartamento.SelectedValue = IdDepa;

            cboProvincia.DataSource = objUbigeoBL.Ubigeo_ProvinciasDepartamento(IdDepa);
            cboProvincia.ValueMember = "IdProv";
            cboProvincia.DisplayMember = "Provincia";
            cboProvincia.SelectedValue = IdProv;

            cboDistrito.DataSource = objUbigeoBL.Ubigeo_DistritosProvinciaDepartamento(IdDepa, IdProv);
            cboDistrito.ValueMember = "IdDist";
            cboDistrito.DisplayMember = "Distrito";
            cboDistrito.SelectedValue = IdDist;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtRS.Text.Trim() == String.Empty)
                {
                    throw new Exception("La razon social es Obligatoria");
                }
                if (mskRuc.MaskFull == false) // Si no llenaste la mascara
                {
                    throw new Exception("El RUC tiene 11 caracteres");
                }

                objEmpresaBE.Raz_soc_emp = txtRS.Text.Trim();
                objEmpresaBE.Dir_emp = txtDir.Text.Trim();
                objEmpresaBE.Tel_emp = txtTel.Text;
                objEmpresaBE.Ruc_emp = mskRuc.Text;
                objEmpresaBE.Rep_emp = txtRepEmp.Text.Trim();
                objEmpresaBE.Estado = Convert.ToInt16(chkEstado.Checked);
                objEmpresaBE.Usu_registro = "jleon";
                objEmpresaBE.Id_Ubigeo = cboDepartamento.SelectedValue.ToString() +
                                           cboProvincia.SelectedValue.ToString() +
                                           cboDistrito.SelectedValue.ToString();

                if (objEmpresaBL.InsertarEmpresa(objEmpresaBE) == true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("No se inserto registro. Contacte con IT.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido el error: " + ex.Message);
            }
        }

        private void cboDepartamento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarUbigeo(cboDepartamento.SelectedValue.ToString(), "01", "01");
        }

        private void cboProvincia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarUbigeo(cboDepartamento.SelectedValue.ToString(), cboProvincia.SelectedValue.ToString(), "01");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mskRuc_Click(object sender, EventArgs e)
        {
            mskRuc.Select(0, 0);
        }
    }
}
