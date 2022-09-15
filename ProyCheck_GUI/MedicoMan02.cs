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
    public partial class MedicoMan02 : Form
    {
        MedicoBL objMedicoBL = new MedicoBL();
        MedicoBE objMedicoBE = new MedicoBE();
        public MedicoMan02()
        {
            InitializeComponent();
        }

        private void MedicoMan02_Load(object sender, EventArgs e)
        {
            try
            {
                CargarUbigeo("14", "01", "01");
                CargarEspecialidad();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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

        private void CargarEspecialidad()
        {
            EspecialidadBL objEspecialidadBL = new EspecialidadBL();

            cboEspecialidad.DataSource = objEspecialidadBL.ListaEspecialidades();
            cboEspecialidad.ValueMember = "codEspecialidad";
            cboEspecialidad.DisplayMember = "descEspecialidad";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtNombre.Text.Length == 0)
                {
                    throw new Exception("El campo Nombre esta vacío.");
                }
                if(txtApellido.Text.Length == 0)
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
                
                if(mskDni.MaskFull == false)
                {
                    throw new Exception("El DNI debe tener 8 dígitos");
                }
                if(mskColegiatura.MaskFull == false)
                {
                    throw new Exception("El num de Colegiatura debe tener 9 dígitos");
                }


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
                objMedicoBE.Usu_registro = "jleon";
                objMedicoBE.Fec_ingreso = dtpFecIngreso.Value;
                objMedicoBE.Id_ubigeo = cboDepartamento.SelectedValue.ToString() +
                                        cboProvincia.SelectedValue.ToString() +
                                        cboDistrito.SelectedValue.ToString();

                if(objMedicoBL.InsertarMedico(objMedicoBE) == true)
                {
                    this.Close();
                } else
                {
                    throw new Exception("No se inserto el registro. Contacte con IT.");
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboProvincia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarUbigeo(cboDepartamento.SelectedValue.ToString(), cboProvincia.SelectedValue.ToString(), "01");
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
