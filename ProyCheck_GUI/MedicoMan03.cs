using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyCheck_BE;
using ProyCheck_BL;

namespace ProyCheck_GUI
{
    public partial class MedicoMan03 : Form
    {
        MedicoBE objMedicoBE = new MedicoBE();
        MedicoBL objMedicoBL = new MedicoBL();

        public MedicoMan03()
        {
            InitializeComponent();
        }

        private String vCodMedico;

        public string VCodMedico { get => vCodMedico; set => vCodMedico = value; }

        private void MedicoMan03_Load(object sender, EventArgs e)
        {
            try
            {
                objMedicoBE = objMedicoBL.ConsultarMedico(this.vCodMedico);

                lblCod.Text = objMedicoBE.CodMedico;

                mskDni.Text = objMedicoBE.DniMedic;
                txtNombre.Text = objMedicoBE.NomMedico;
                txtApellido.Text = objMedicoBE.ApeMedico;
                mskColegiatura.Text = objMedicoBE.NumColegiatura;
                dtpFecNacimiento.Value = objMedicoBE.FechaNacimiento;
                txtEmail.Text = objMedicoBE.EmailMedico;
                txtDireccion.Text = objMedicoBE.DirecMedico;
                chkActivo.Checked = Convert.ToBoolean(objMedicoBE.Estado);

                CargarEspecialidad(objMedicoBE.CodEspecialidad);

                String Id_Ubigeo = objMedicoBE.Id_ubigeo;

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

        private void CargarEspecialidad(String codEspecialidad)
        {
            EspecialidadBL objEspecialidadBL = new EspecialidadBL();

            cboEspecialidad.DataSource = objEspecialidadBL.ListaEspecialidades();
            cboEspecialidad.ValueMember = "codEspecialidad";
            cboEspecialidad.DisplayMember = "descEspecialidad";
            cboEspecialidad.SelectedValue = codEspecialidad;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtNombre.Text.Length == 0)
                {
                    throw new Exception("El campo Nombre esta vacío.");
                }
                if (txtApellido.Text.Length == 0)
                {
                    throw new Exception("El campo Apellido esta vacío.");
                }
                if (txtEmail.Text.Length == 0)
                {
                    throw new Exception("El Email no puede estar vacío.");
                }
                if (txtDireccion.Text.Length == 0)
                {
                    throw new Exception("La dirección no puede estar vacía.");
                }

                if (mskDni.MaskFull == false)
                {
                    throw new Exception("El DNI debe tener 8 dígitos");
                }
                if (mskColegiatura.MaskFull == false)
                {
                    throw new Exception("El num de Colegiatura debe tener 9 dígitos");
                }


                objMedicoBE.CodMedico = lblCod.Text;
                objMedicoBE.DniMedic = mskDni.Text;
                objMedicoBE.NomMedico = txtNombre.Text.Trim();
                objMedicoBE.ApeMedico = txtApellido.Text.Trim();
                objMedicoBE.NumColegiatura = mskColegiatura.Text;
                objMedicoBE.FechaNacimiento = dtpFecNacimiento.Value;
                objMedicoBE.EmailMedico = txtEmail.Text.Trim();
                objMedicoBE.FotoMedico = "";
                objMedicoBE.DirecMedico = txtDireccion.Text.Trim();
                objMedicoBE.Estado = Convert.ToInt16(chkActivo.Checked);
                objMedicoBE.CodEspecialidad = cboEspecialidad.SelectedValue.ToString();
                objMedicoBE.Login_usuario = "pcalderon2021";
                objMedicoBE.Usu_ult_mod = "jleon";
                objMedicoBE.Id_ubigeo = cboDepartamento.SelectedValue.ToString() +
                                        cboProvincia.SelectedValue.ToString() +
                                        cboDistrito.SelectedValue.ToString();

                if(objMedicoBL.ActualizarMedico(objMedicoBE) == true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("No se actualizó el registro. Contacte a IT.");
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
            CargarUbigeo(cboDepartamento.SelectedValue.ToString(),
                                cboProvincia.SelectedValue.ToString(), "01");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mskDni_Click(object sender, EventArgs e)
        {
            mskDni.Select(0, 0);
        }

        private void mskColegiatura_Click(object sender, EventArgs e)
        {
            mskColegiatura.Select(0, 0);
        }

        
    }
}
