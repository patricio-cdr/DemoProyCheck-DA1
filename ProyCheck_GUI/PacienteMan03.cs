using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Agrego 
using ProyCheck_BE;
using ProyCheck_BL;

namespace ProyCheck_GUI
{
    public partial class PacienteMan03 : Form
    {
        PacienteBE objPacienteBE = new PacienteBE();
        PacienteBL objPacienteBL = new PacienteBL();

        public PacienteMan03()
        {
            InitializeComponent();
        }

        private String mvCod;
        private int mvSexo;
        private String tipoPaciente;

        public string MvCod { get => mvCod; set => mvCod = value; }

        private void PacienteMan03_Load(object sender, EventArgs e)
        {
            try
            {
                // Mostramos los datos del paciente a actualizar
                objPacienteBE = objPacienteBL.ConsultarPaciente(this.MvCod);

                lblCod.Text = objPacienteBE.CodPaciente;
                
                txtNom.Text = objPacienteBE.NomPaciente;
                txtApe.Text = objPacienteBE.ApePaciente;
                dtpFecNaci.Value = objPacienteBE.FechaNacimiento;
                mskDNI.Text = objPacienteBE.DniPaciente;
                
                // Validamos el sexo del paciente
                mvSexo = objPacienteBE.Sexo;
                if(mvSexo == 0)
                {
                    optHombre.Checked = true;
                }
                else
                {
                    optMujer.Checked = true;
                }

                txtDirec.Text = objPacienteBE.DirecPaciente;
                cboSangre.Text = objPacienteBE.TipoSangre;
                txtEmail.Text = objPacienteBE.EmailPaciente;
                dtpFecIngreso.Value = objPacienteBE.FechaIngreso;
                txtTel.Text = objPacienteBE.NumTelefono;
                chkActivo.Checked = Convert.ToBoolean(objPacienteBE.Estado);

                // Establecemos el tipo de paciente elegido como un int
                switch (objPacienteBE.TipoCliente)
                {
                    case 1:
                        tipoPaciente = "Gerente";
                        break;
                    case 2:
                        tipoPaciente = "Administrativo";
                        break;
                    case 3:
                        tipoPaciente = "Operacional";
                        break;
                    default: throw new Exception("");
                }
                
                cboTipoPaci.Text = tipoPaciente;
                CargarEmpresa(objPacienteBE.CodEmpresa);

                // Mostramos el ubigeo...
                // Los 2 primeros caracteres son el IdDepa
                // el 3er y 4to caracter son el IdProv
                // el 5to y 6to caracter son el IdDist
                String Id_Ubigeo = objPacienteBE.Id_ubigeo;

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

        private void CargarEmpresa(String codEmpresa)
        {
            EmpreRazonSocialBL objEmpreRazonSocialBL = new EmpreRazonSocialBL();

            cboEmpresa.DataSource = objEmpreRazonSocialBL.Empresa_RazonSocial();
            cboEmpresa.ValueMember = "codEmpresa";
            cboEmpresa.DisplayMember = "Raz_soc_emp";
            cboEmpresa.SelectedValue = codEmpresa;
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
                if (optHombre.Checked == true)
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


                objPacienteBE.CodPaciente = lblCod.Text;
                objPacienteBE.NomPaciente = txtNom.Text.Trim();
                objPacienteBE.ApePaciente = txtApe.Text.Trim();
                objPacienteBE.FechaNacimiento = dtpFecNaci.Value;
                objPacienteBE.DniPaciente = mskDNI.Text;
                objPacienteBE.Sexo = (short)sexo;
                objPacienteBE.DirecPaciente = txtDirec.Text.Trim();
                objPacienteBE.TipoSangre = cboSangre.Text.ToString();
                objPacienteBE.FotoPaciente = "";
                objPacienteBE.EmailPaciente = txtEmail.Text.Trim();
                objPacienteBE.FechaIngreso = dtpFecIngreso.Value;
                objPacienteBE.NumTelefono = txtTel.Text.Trim();
                objPacienteBE.Estado = Convert.ToInt16(chkActivo.Checked);
                objPacienteBE.TipoCliente = (short)tipoPaciente;
                objPacienteBE.CodEmpresa = cboEmpresa.SelectedValue.ToString();
                objPacienteBE.Usu_ult_mod = "jleon";// por ahora....

                objPacienteBE.Id_ubigeo = cboDepartamento.SelectedValue.ToString() +
                                                                cboProvincia.SelectedValue.ToString() +
                                                                cboDistrito.SelectedValue.ToString();

                if (objPacienteBL.ActualizarPaciente(objPacienteBE) == true)
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

        private void mskDNI_Click(object sender, EventArgs e)
        {
            mskDNI.Select(0, 0);
        }
    }

}
