using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ProyCheck_ADO;
namespace ProyCheck_BL
{
    public class AnalisisBL
    {
        AnalisisADO objAnalisisADO = new AnalisisADO();

        public DataTable ConsultarAnalisis(String strCod)
        {
            return objAnalisisADO.ConsultarAnalisis(strCod);
        }

        public DataTable ListarAnalisis()
        {
            return objAnalisisADO.ListarAnalisis();
        }
    }
}
