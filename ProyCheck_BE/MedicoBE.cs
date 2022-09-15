using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyCheck_BE
{
    public class MedicoBE
    {
        private String codMedico;
        private String dniMedic;
        private String nomMedico;
        private String apeMedico;
        private String numColegiatura;
        private DateTime fechaNacimiento;
        private String emailMedico;
        private String fotoMedico;
        private String direcMedico;
        private Int16 estado;
        private String codEspecialidad;
        private String login_usuario;
        private DateTime fech_reg;
        private String usu_registro;
        private DateTime fech_ult_mod;
        private String usu_ult_mod;
        private String id_ubigeo;
        private DateTime fec_ingreso;

        private int edad;
        private int anhoTrabajo;
        private String descEstado;
        private String nomEspecialidad;
        private String nomUbigeo;


        public string CodMedico { get => codMedico; set => codMedico = value; }
        public string DniMedic { get => dniMedic; set => dniMedic = value; }
        public string NomMedico { get => nomMedico; set => nomMedico = value; }
        public string ApeMedico { get => apeMedico; set => apeMedico = value; }
        public string NumColegiatura { get => numColegiatura; set => numColegiatura = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string EmailMedico { get => emailMedico; set => emailMedico = value; }
        public string FotoMedico { get => fotoMedico; set => fotoMedico = value; }
        public string DirecMedico { get => direcMedico; set => direcMedico = value; }
        public short Estado { get => estado; set => estado = value; }
        public string DescEstado { get => descEstado; set => descEstado = value; }
        public string CodEspecialidad { get => codEspecialidad; set => codEspecialidad = value; }
        public string Login_usuario { get => login_usuario; set => login_usuario = value; }
        public DateTime Fech_reg { get => fech_reg; set => fech_reg = value; }
        public string Usu_registro { get => usu_registro; set => usu_registro = value; }
        public DateTime Fech_ult_mod { get => fech_ult_mod; set => fech_ult_mod = value; }
        public string Usu_ult_mod { get => usu_ult_mod; set => usu_ult_mod = value; }
        public string Id_ubigeo { get => id_ubigeo; set => id_ubigeo = value; }
        public DateTime Fec_ingreso { get => fec_ingreso; set => fec_ingreso = value; }
        public int Edad { get => edad; set => edad = value; }
        public int AnhoTrabajo { get => anhoTrabajo; set => anhoTrabajo = value; }

        public string NomEspecialidad { get => nomEspecialidad; set => nomEspecialidad = value; }

        public string NomUbigeo { get => nomUbigeo; set => nomUbigeo = value; }
    }
}
