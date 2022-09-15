using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Agregamos
using System.Data;
using ProyCheck_BE;
using ProyCheck_ADO;

namespace ProyCheck_BL
{
    public class EmpresaBL
    {
        EmpresaADO objEmpresaADO = new EmpresaADO();

        public Boolean InsertarEmpresa(EmpresaBE objEmpresaBE)
        {
            return objEmpresaADO.InsertarEmpresa(objEmpresaBE);
        }
        public Boolean ActualizarEmpresa(EmpresaBE objEmpresaBE)
        {
            return objEmpresaADO.ActualizarEmpresa(objEmpresaBE);
        }
        public Boolean EliminarEmpresa(String strcod)
        {
            return objEmpresaADO.EliminarEmpresa(strcod);
        }

        public EmpresaBE ConsultarEmpresa(String strcod)
        {
            return objEmpresaADO.ConsultarEmpresa(strcod);
        }

        public DataTable ListarEmpresa()
        {
            return objEmpresaADO.ListarEmpresa();
        }

        public DataTable ListarEmpresaxUbicacion(String dep, String prov, String dist)
        {
            return objEmpresaADO.ListarEmpresaxUbicacion(dep, prov, dist);
        }

    }
}
