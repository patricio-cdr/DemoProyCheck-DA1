using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyCheck_BE
{
    public class PacienteBE
    {
        private String codPaciente;
        private String nomPaciente;
        private String apePaciente;
        private DateTime fechaNacimiento;
        private String dniPaciente;
        private Int16 sexo;
        private String direcPaciente;
        private String tipoSangre;
        private String fotoPaciente;
        private String emailPaciente;
        private DateTime fechaIngreso;
        private String numTelefono;
        private Int16 estado;
        private Int16 tipoCliente;
        private String codEmpresa;
        private DateTime fec_reg;
        private String usu_registro;
        private DateTime fec_ult_mod;
        private String usu_ult_mod;
        private String id_ubigeo;
        private String genero;
        private String nomEmpresa;
        private Int16 cantidadEvas;
        private String lugar_de_trabajo;
        private String tipo_cliente;
        private String estado_actual;



        public string CodPaciente { get => codPaciente; set => codPaciente = value; }
        public string NomPaciente { get => nomPaciente; set => nomPaciente = value; }
        public string ApePaciente { get => apePaciente; set => apePaciente = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string DniPaciente { get => dniPaciente; set => dniPaciente = value; }
        public short Sexo { get => sexo; set => sexo = value; }
        public string DirecPaciente { get => direcPaciente; set => direcPaciente = value; }
        public string TipoSangre { get => tipoSangre; set => tipoSangre = value; }
        public string FotoPaciente { get => fotoPaciente; set => fotoPaciente = value; }
        public string EmailPaciente { get => emailPaciente; set => emailPaciente = value; }
        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public string NumTelefono { get => numTelefono; set => numTelefono = value; }
        public short Estado { get => estado; set => estado = value; }
        public short TipoCliente { get => tipoCliente; set => tipoCliente = value; }
        public string CodEmpresa { get => codEmpresa; set => codEmpresa = value; }
        public DateTime Fec_reg { get => fec_reg; set => fec_reg = value; }
        public string Usu_registro { get => usu_registro; set => usu_registro = value; }
        public DateTime Fec_ult_mod { get => fec_ult_mod; set => fec_ult_mod = value; }
        public string Usu_ult_mod { get => usu_ult_mod; set => usu_ult_mod = value; }
        public string Id_ubigeo { get => id_ubigeo; set => id_ubigeo = value; }
        public string Genero { get => genero; set => genero = value; }
        public string NomEmpresa { get => nomEmpresa; set => nomEmpresa = value; }
        public short CantidadEvas { get => cantidadEvas; set => cantidadEvas = value; }
        public string Lugar_de_trabajo { get => lugar_de_trabajo; set => lugar_de_trabajo = value; }
        public string Tipo_cliente { get => tipo_cliente; set => tipo_cliente = value; }
        public string Estado_actual { get => estado_actual; set => estado_actual = value; }
    }
}
