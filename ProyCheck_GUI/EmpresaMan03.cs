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
    public partial class EmpresaMan03 : Form
    {
        EmpresaBL objEmpresaBL = new EmpresaBL();
        EmpresaBE objEmpresaBE = new EmpresaBE();

        public EmpresaMan03()
        {
            InitializeComponent();
        }

        private String mvCod;

        public string MvCod { get => mvCod; set => mvCod = value; }

        private void EmpresaMan03_Load(object sender, EventArgs e)
        {
            try
            {
                objEmpresaBE = objEmpresaBL.ConsultarEmpresa(this.MvCod);
                
                lblCod.Text = objEmpresaBE.CodEmpresa;
                txtRS.Text = objEmpresaBE.Raz_soc_emp;
                txtDir.Text = objEmpresaBE.Dir_emp;
                txtTel.Text = objEmpresaBE.Tel_emp;
                mskRuc.Text = objEmpresaBE.Ruc_emp;
                txtRepEmp.Text = objEmpresaBE.Rep_emp;
                chkEstado.Checked = Convert.ToBoolean(objEmpresaBE.Estado);

                string Id_Ubigeo = objEmpresaBE.Id_Ubigeo;
                CargarUbigeo(Id_Ubigeo.Substring(0, 2), Id_Ubigeo.Substring(2, 2), Id_Ubigeo.Substring(4, 2));
                
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
                if (mskRuc.MaskFull == false)
                {
                    throw new Exception("El RUC tiene 11 caracteres");
                }
                objEmpresaBE.CodEmpresa = lblCod.Text;
                objEmpresaBE.Raz_soc_emp = txtRS.Text.Trim();
                objEmpresaBE.Dir_emp = txtDir.Text.Trim();
                objEmpresaBE.Ruc_emp = mskRuc.Text;
                objEmpresaBE.Tel_emp = txtTel.Text.Trim();
                objEmpresaBE.Rep_emp = txtRepEmp.Text.Trim();
                objEmpresaBE.Estado = Convert.ToInt16(chkEstado.Checked);
                objEmpresaBE.Usu_ult_mod = "jleon"; // por ahora
                objEmpresaBE.Id_Ubigeo = cboDepartamento.SelectedValue.ToString() +
                              cboProvincia.SelectedValue.ToString() +
                               cboDistrito.SelectedValue.ToString();


                if (objEmpresaBL.ActualizarEmpresa(objEmpresaBE) == true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("No se actualizó registro. Contacte con IT.");
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboProvincia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarUbigeo(cboDepartamento.SelectedValue.ToString(),
                    cboProvincia.SelectedValue.ToString(), "01");
        }

        private void mskRuc_Click(object sender, EventArgs e)
        {
            mskRuc.Select(0, 0);
        }
    }
}
