using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Agregar el Business Logic
using ProyCheck_BL;

namespace ProyCheck_GUI
{
    public partial class PacienteMan01 : Form
    {
        PacienteBL objPacienteBL = new PacienteBL();
        DataView dtv; // para el filtro por dni

        public PacienteMan01()
        {
            InitializeComponent();
        }

        public void CargarDatos(String strFiltro)
        {

            dtv.RowFilter = "Dni like '%" + strFiltro + "%'";
            dtgPaciente.DataSource = dtv;

            lblRegistros.Text = dtgPaciente.Rows.Count.ToString();
        }

        private void PacienteMan01_Load(object sender, EventArgs e)
        {
            try
            {
                // Para que no autogenere columnas y solo considere las que se han personalizado
                dtgPaciente.AutoGenerateColumns = false;
                // Definimos el dataview...
                dtv = objPacienteBL.ListarPaciente().DefaultView;
                CargarDatos(String.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            CargarDatos(txtFiltro.Text.Trim());
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                PacienteMan02 obj02 = new PacienteMan02();
                obj02.ShowDialog();

                // Refrescar...
                dtv = objPacienteBL.ListarPaciente().DefaultView;
                CargarDatos(txtFiltro.Text.Trim());

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);

            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtenemos el codigo del paciente que se va a actualizar...
                String strcod = dtgPaciente.CurrentRow.Cells[0].Value.ToString();

                PacienteMan03 obj03 = new PacienteMan03();
                obj03.MvCod = strcod;
                obj03.ShowDialog();

                // Refrescar...
                dtv = objPacienteBL.ListarPaciente().DefaultView;
                CargarDatos(txtFiltro.Text.Trim());

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgPaciente_DoubleClick(object sender, EventArgs e)
        {
            btnActualizar.PerformClick();
        }
    }
}
