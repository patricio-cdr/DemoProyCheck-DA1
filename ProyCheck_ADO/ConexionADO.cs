using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration; // Para la clase ConfigurationManager

namespace ProyCheck_ADO
{
    class ConexionADO
    {
        public string GetCnx()
        {
            string strCnx = 
                ConfigurationManager.ConnectionStrings["Check"].ConnectionString;
            if (object.ReferenceEquals(strCnx, string.Empty))
            {
                return string.Empty;
            }
            else
            {
                return strCnx;
            }
        }

    }
}
