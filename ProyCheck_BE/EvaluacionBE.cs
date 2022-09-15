using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyCheck_BE
{
    public class EvaluacionBE
    {
        private string cod_evaluacion, cod_medico, cod_auditor, usu_registro, usu_ult_mod, apellido_pac,
            nombre_pac,fec_nac,dni_paciente, lugar_trabajo, tipo_examen, sangre, orina, ekg, spirometria,
            psicologia,rayosX, audicion,vista, recomendaciones, nom_med_eva, ape_med_eva, nom_med_aud,
            ape_med_aud;
        private DateTime fec_eva, fec_Reg, fec_ult_mod;
        private int estado,edad;
        private float peso_paciente;

        public string Cod_evaluacion { get => cod_evaluacion; set => cod_evaluacion = value; }
        public string Cod_medico { get => cod_medico; set => cod_medico = value; }
        public string Cod_auditor { get => cod_auditor; set => cod_auditor = value; }
        public string Usu_registro { get => usu_registro; set => usu_registro = value; }
        public string Usu_ult_mod { get => usu_ult_mod; set => usu_ult_mod = value; }
        public string Apellido_pac { get => apellido_pac; set => apellido_pac = value; }
        public string Nombre_pac { get => nombre_pac; set => nombre_pac = value; }
        public string Fec_nac { get => fec_nac; set => fec_nac = value; }
        public string Dni_paciente { get => dni_paciente; set => dni_paciente = value; }
        public string Lugar_trabajo { get => lugar_trabajo; set => lugar_trabajo = value; }
        public string Tipo_examen { get => tipo_examen; set => tipo_examen = value; }
        public string Sangre { get => sangre; set => sangre = value; }
        public string Orina { get => orina; set => orina = value; }
        public string Ekg { get => ekg; set => ekg = value; }
        public string Spirometria { get => spirometria; set => spirometria = value; }
        public string Psicologia { get => psicologia; set => psicologia = value; }
        public string RayosX { get => rayosX; set => rayosX = value; }
        public string Audicion { get => audicion; set => audicion = value; }
        public string Vista { get => vista; set => vista = value; }
        public string Recomendaciones { get => recomendaciones; set => recomendaciones = value; }
        public string Nom_med_eva { get => nom_med_eva; set => nom_med_eva = value; }
        public string Ape_med_eva { get => ape_med_eva; set => ape_med_eva = value; }
        public string Nom_med_aud { get => nom_med_aud; set => nom_med_aud = value; }
        public string Ape_med_aud { get => ape_med_aud; set => ape_med_aud = value; }
        public DateTime Fec_eva { get => fec_eva; set => fec_eva = value; }
        public DateTime Fec_Reg { get => fec_Reg; set => fec_Reg = value; }
        public DateTime Fec_ult_mod { get => fec_ult_mod; set => fec_ult_mod = value; }
        public int Estado { get => estado; set => estado = value; }
        public int Edad { get => edad; set => edad = value; }
        public float Peso_paciente { get => peso_paciente; set => peso_paciente = value; }
    }
}
