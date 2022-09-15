using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyCheck_BE
{
	public class EmpresaBE
	{
		private String codEmpresa;
		private String raz_soc_emp;
		private String dir_emp;
		private String tel_emp;
		private String ruc_emp;
		private String rep_emp;
		private String id_Ubigeo;
		private DateTime fec_Ingreso;
		private Int16 estado;
        private DateTime fec_reg;
        private String usu_registro;
        private DateTime fec_ult_mod;
        private String usu_ult_mod;
        private Int16 años_servicios;
        private String est_actual;
        private String departamento;
        private String provincia;
        private String distrito;
        private Int16 trabajadores_Evaluados;

        public string CodEmpresa { get => codEmpresa; set => codEmpresa = value; }
        public string Raz_soc_emp { get => raz_soc_emp; set => raz_soc_emp = value; }
        public string Dir_emp { get => dir_emp; set => dir_emp = value; }
        public string Tel_emp { get => tel_emp; set => tel_emp = value; }
        public string Ruc_emp { get => ruc_emp; set => ruc_emp = value; }
        public string Rep_emp { get => rep_emp; set => rep_emp = value; }
        public string Id_Ubigeo { get => id_Ubigeo; set => id_Ubigeo = value; }
        public DateTime Fec_Ingreso { get => fec_Ingreso; set => fec_Ingreso = value; }
        public short Estado { get => estado; set => estado = value; }
        public DateTime Fec_reg { get => fec_reg; set => fec_reg = value; }
        public string Usu_registro { get => usu_registro; set => usu_registro = value; }
        public DateTime Fec_ult_mod { get => fec_ult_mod; set => fec_ult_mod = value; }
        public string Usu_ult_mod { get => usu_ult_mod; set => usu_ult_mod = value; }
        public short Años_servicios { get => años_servicios; set => años_servicios = value; }
        public string Est_actual { get => est_actual; set => est_actual = value; }
        public string Departamento { get => departamento; set => departamento = value; }
        public string Provincia { get => provincia; set => provincia = value; }
        public string Distrito { get => distrito; set => distrito = value; }
        public short Trabajadores_Evaluados { get => trabajadores_Evaluados; set => trabajadores_Evaluados = value; }
    }
}
