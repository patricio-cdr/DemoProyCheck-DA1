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

namespace ProyCheck_GUI
{
    public partial class MedicoMan01 : Form
    {
        MedicoBL objMedicoBL = new MedicoBL();
        DataView dtv;
        public MedicoMan01()
        {
            InitializeComponent();
        }

        public void CargarDatos(String fltrDni, String fltrApellido)
        {
            dtv.RowFilter = "dniMedic like '%" + fltrDni + "%' and apeMedico like '%" + fltrApellido + "%'";
            dtgMedico.DataSource = dtv;

            lblRegistroCount.Text = dtgMedico.Rows.Count.ToString();
        }

        private void MedicoMan01_Load(object sender, EventArgs e)
        {
            try
            {
                dtgMedico.AutoGenerateColumns = false;
                dtv = objMedicoBL.ListarMedico().DefaultView;
                CargarDatos(String.Empty, String.Empty);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            CargarDatos(txtDni.Text.Trim(), txtApellido.Text.Trim());
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            CargarDatos(txtDni.Text.Trim(), txtApellido.Text.Trim());
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                MedicoMan02 obj02 = new MedicoMan02();
                obj02.ShowDialog();

                dtv = objMedicoBL.ListarMedico().DefaultView;
                CargarDatos(txtDni.Text.Trim(), txtApellido.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                String strcod = dtgMedico.CurrentRow.Cells[0].Value.ToString();
                
                MedicoMan03 obj03 = new MedicoMan03();
                obj03.VCodMedico = strcod;
                obj03.ShowDialog();

                dtv = objMedicoBL.ListarMedico().DefaultView;
                CargarDatos(txtDni.Text.Trim(), txtApellido.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgMedico_DoubleClick(object sender, EventArgs e)
        {
            btnActualizar.PerformClick();
        }
    }
}
