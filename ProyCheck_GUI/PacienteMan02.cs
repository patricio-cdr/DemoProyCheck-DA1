using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Agregamos
using ProyCheck_BL;
using ProyCheck_BE;


namespace ProyCheck_GUI
{
    public partial class PacienteMan02 : Form
    {
        PacienteBL objPacienteBL = new PacienteBL();
        PacienteBE objPacienteBE = new PacienteBE();

        public PacienteMan02()
        {
            InitializeComponent();
        }

        private void PacienteMan02_Load(object sender, EventArgs e)
        {
            try
            {
                // Cargamos los combos de Ubigeo
                // Por defecto elegiremos Lima, Lima , Lima (14,01,01)
                CargarUbigeo("14", "01", "01");
                CargarEmpresa();
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

        private void CargarEmpresa()
        {
            EmpreRazonSocialBL objEmpreRazonSocialBL = new EmpreRazonSocialBL();

            cboEmpresa.DataSource = objEmpreRazonSocialBL.Empresa_RazonSocial();
            cboEmpresa.ValueMember = "codEmpresa";
            cboEmpresa.DisplayMember = "Raz_soc_emp";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int tipoPaciente;
            int sexo;

            try
            {
                if (txtNom.Text.Length == 0)
                {
                    throw new Exception("El Nombre no puede estar vacio.");
                }

                if (txtApe.Text.Length == 0)
                {
                    throw new Exception("El Apellido no puede estar vacio.");
                }

                if (optHombre.Checked == false & optMujer.Checked == false)
                {
                    throw new Exception("Debe elegir un sexo.");

                }

                // Establecemos el sexo elegido como un int, 0 para hombre y 1 para mujer
                if(optHombre.Checked == true)
                {
                    // Hombre
                    sexo = 0;
                }
                else
                {
                    // Mujer 
                    sexo = 1;
                }

                if (txtDirec.Text.Length == 0)
                {
                    throw new Exception("La dirección no puede estar vacia.");

                }

                if (txtTel.Text.Length == 0)
                {
                    throw new Exception("Debe ingresar un teléfono.");

                }
                // Cargamos las propiedades de la entidad de negocios...
                // Validamos que el DNI se haya llenado completamente

                if (mskDNI.MaskFull == false) // Si no llenaste la mascara
                {
                    throw new Exception("El DNI debe tener 8 caracteres");

                }

                // Establecemos el tipo de paciente elegido como un int
                switch (cboTipoPaci.SelectedItem.ToString())
                {
                    case "Gerente":
                        tipoPaciente = 1;
                        break;
                    case "Administrativo":
                        tipoPaciente = 2;
                        break;
                    case "Operacional":
                        tipoPaciente = 3;
                    break;
                        default: throw new Exception("Debe elegir un tipo de paciente");
                }



                objPacienteBE.CodPaciente = "";
                objPacienteBE.NomPaciente = txtNom.Text.Trim();
                objPacienteBE.ApePaciente = txtApe.Text.Trim();
                objPacienteBE.FechaNacimiento = dtpFecNaci.Value;
                objPacienteBE.DniPaciente = mskDNI.Text;
                objPacienteBE.Sexo = (short)sexo;
                objPacienteBE.DirecPaciente = txtDirec.Text.Trim();
                objPacienteBE.TipoSangre = cboSangre.SelectedItem.ToString();
                objPacienteBE.FotoPaciente = ""; 
                objPacienteBE.EmailPaciente = txtEmail.Text.Trim();
                objPacienteBE.FechaIngreso = dtpFecIngreso.Value;
                objPacienteBE.NumTelefono = txtTel.Text.Trim();
                objPacienteBE.Estado = Convert.ToInt16(chkActivo.Checked);
                objPacienteBE.TipoCliente = (short)tipoPaciente;
                objPacienteBE.CodEmpresa = cboEmpresa.SelectedValue.ToString();
                objPacienteBE.Usu_registro = "jleon";// por ahora....

                objPacienteBE.Id_ubigeo = cboDepartamento.SelectedValue.ToString() +
                                                                cboProvincia.SelectedValue.ToString() +
                                                                cboDistrito.SelectedValue.ToString();

                if (objPacienteBL.InsertarPaciente(objPacienteBE) == true)
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
            // Refrescamos 
            CargarUbigeo(cboDepartamento.SelectedValue.ToString(), "01", "01");

        }

        private void cboProvincia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // Refrescamos 
            CargarUbigeo(cboDepartamento.SelectedValue.ToString(), cboProvincia.SelectedValue.ToString(), "01");


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mskDNI_Click(object sender, EventArgs e)
        {
            mskDNI.Select(0, 0);
        }
    }
}
