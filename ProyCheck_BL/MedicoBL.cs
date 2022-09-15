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
    public class MedicoBL
    {
        MedicoADO objMedicoADO = new MedicoADO();

        public Boolean InsertarMedico(MedicoBE objMedicoBE)
        {
            return objMedicoADO.InsertarMedico(objMedicoBE);
        }

        public Boolean ActualizarMedico(MedicoBE objMedicoBE)
        {
            return objMedicoADO.ActualizarMedico(objMedicoBE);
        }

        public MedicoBE ConsultarMedico(String strcod)
        {
            return objMedicoADO.ConsultarMedico(strcod);
        }

        public DataTable ListarMedico()
        {
            return objMedicoADO.ListarMedico();
        }

        public DataTable ListarPacientesxMedico(String strcod, DateTime fecini)
        {
            return objMedicoADO.ListarPacientesxMedico(strcod, fecini);
        }
    }
}
