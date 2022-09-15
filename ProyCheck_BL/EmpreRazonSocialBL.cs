using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Agregamos los using...
using ProyCheck_ADO;
using ProyCheck_BE;
using System.Data;

namespace ProyCheck_BL
{
    public class EmpreRazonSocialBL
    {
        EmpreRazonSocialADO objEmpreRazonSocialADO = new EmpreRazonSocialADO();

        public DataTable Empresa_RazonSocial()
        {
            return objEmpreRazonSocialADO.Empresa_RazonSocial();
        }
    }
}
