using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ProyCheck_BE;
using ProyCheck_ADO;


namespace ProyCheck_BL
{
    public class PacienteBL
    {
        PacienteADO objPacienteADO = new PacienteADO();

        public Boolean InsertarPaciente(PacienteBE objPacienteBE)
        {
            return objPacienteADO.InsertarPaciente(objPacienteBE);
        }
        public Boolean ActualizarPaciente(PacienteBE objPacienteBE)
        {
            return objPacienteADO.ActualizarPaciente(objPacienteBE);
        }
        public Boolean EliminarPaciente(String strcod)
        {
            return objPacienteADO.EliminarPaciente(strcod);
        }

        public PacienteBE ConsultarPaciente(String strcod)
        {
            return objPacienteADO.ConsultarPaciente(strcod);
        }

        public DataTable ListarPaciente()
        {
            return objPacienteADO.ListarPaciente();
        }

        public DataTable ConsultarPacientesXEvaluaciones(String tipCli, Int16 cantEval)
        {
            return objPacienteADO.ConsultarPacientesXEvaluaciones(tipCli, cantEval);
        }
    }
}
