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
    public partial class EmpresaMan01 : Form
    {
        EmpresaBL objEmpresaBL = new EmpresaBL();
        DataView dtv; // para el filtro por Razon social

        public EmpresaMan01()
        {
            InitializeComponent();
        }

        public void CargarDatos(String strFiltro)
        {
            dtv.RowFilter = "Ruc_emp like '%" + strFiltro + "%'";
            dtgEmpresa.DataSource = dtv;

            lblRegistros.Text = dtgEmpresa.Rows.Count.ToString();
        }

        private void EmpresaMan01_Load(object sender, EventArgs e)
        {
            try
            {
                // Para que no autogenere columnas y solo considere las que se han personalizado
                dtgEmpresa.AutoGenerateColumns = false;
                // Definimos el dataview...
                dtv = objEmpresaBL.ListarEmpresa().DefaultView;
                CargarDatos(String.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                EmpresaMan02 emp02 = new EmpresaMan02();
                emp02.ShowDialog();

                dtv = new DataView(objEmpresaBL.ListarEmpresa());
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
                // Obtenemos el codigo de la empresa que se va a actualizar...
                String strCod = dtgEmpresa.CurrentRow.Cells[0].Value.ToString();

                EmpresaMan03 obj03 = new EmpresaMan03();
                obj03.MvCod = strCod;
                obj03.ShowDialog();

                dtv = objEmpresaBL.ListarEmpresa().DefaultView;
                CargarDatos(txtFiltro.Text.Trim());
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgEmpresa_DoubleClick(object sender, EventArgs e)
        {
            btnActualizar.PerformClick();
        }

        private void dtgEmpresa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblRegistros_Click(object sender, EventArgs e)
        {

        }
    }
}
