using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyCheck_BE
{
    public class UsuarioBE
    {

        private String login_usu, password_usu, usu_registro;
        private int nivel_usu, est_usu;
        private DateTime fec_registro;

        public string Login_usu { get => login_usu; set => login_usu = value; }
        public string Password_usu { get => password_usu; set => password_usu = value; }
        public string Usu_registro { get => usu_registro; set => usu_registro = value; }
        public int Nivel_usu { get => nivel_usu; set => nivel_usu = value; }
        public int Est_usu { get => est_usu; set => est_usu = value; }
        public DateTime Fec_registro { get => fec_registro; set => fec_registro = value; }
    }
}
