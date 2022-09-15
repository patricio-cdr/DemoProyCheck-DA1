using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProyCheck_ADO;
using ProyCheck_BE;
using System.Data;

namespace ProyCheck_BL
{
    public class EspecialidadBL
    {
        EspecialidadADO objEspecialidadADO = new EspecialidadADO();

        public DataTable ListaEspecialidades()
        {
            return objEspecialidadADO.ListaEspecialidades();
        }
    }
}
