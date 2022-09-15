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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            UsuarioBL objUsuarioBL = new UsuarioBL();
            String usuario = txtUsuario.Text.Trim();
            String psw = txtContraseña.Text.Trim();

            if (psw.Length == 0 & usuario.Length == 0)
            {
                MessageBox.Show("Contraseña vacia y Usuario vacios", "Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            String usuarioLog = objUsuarioBL.ConsultarUsuario(usuario).Login_usu;
            String usuarioPsw = objUsuarioBL.ConsultarUsuario(usuario).Password_usu;

            if (usuarioLog == null & usuarioPsw == null)
            {
                MessageBox.Show("Usuario y contraseña incorrectos");
                return;
            }
            else if (usuario == usuarioLog)
            {
                if(usuarioPsw != psw)
                {
                    MessageBox.Show("Contraseña incorrecta");
                }
                else
                {
                    clsCredenciales.Usuario = usuarioLog;
                    clsCredenciales.Password = usuarioPsw;

                    MDIPrincipal mdi = new MDIPrincipal();
                    mdi.Show();
                    this.Hide();
                }
            }

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
