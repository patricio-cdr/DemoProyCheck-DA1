using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyCheck_GUI
{
    public partial class MDIPrincipal : Form
    {
        public MDIPrincipal()
        {
            InitializeComponent();
        }

        private void MDIPrincipal_Resize(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PacienteMan01 objpPacienteMan01 = new PacienteMan01();
            objpPacienteMan01.MdiParent = this;
            objpPacienteMan01.Show();
        }

        private void empresasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmpresaMan01 objEmpresaMan01 = new EmpresaMan01();
            objEmpresaMan01.MdiParent = this;
            objEmpresaMan01.Show();
        }

        private void evaluacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MedicoMan01 objMedicoMan01 = new MedicoMan01();
            objMedicoMan01.MdiParent = this;
            objMedicoMan01.Show();
        }

        private void MDIPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login objLogin = (Login)Application.OpenForms["Login"];
            objLogin.Close();
            Application.Exit();
        }

        private void MDIPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Solicitar confirmacion al cerrar
            DialogResult vrpta;
            vrpta = MessageBox.Show("¿Seguro de salir?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (vrpta == DialogResult.No)
            {
                e.Cancel = true; // Se cancela el cierre del formulario
            }
        }

        private void MDIPrincipal_Load(object sender, EventArgs e)
        {
            this.lblUsuario.Text = "Usuario: " + clsCredenciales.Usuario;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
