using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyCheck_BE;
using ProyCheck_ADO;

namespace ProyCheck_BL
{
    public class UsuarioBL
    {
        UsuarioADO objUsuario = new UsuarioADO();
        public UsuarioBE ConsultarUsuario(String strLog)
        {
            return objUsuario.ConsultarUsuario(strLog);
        }
    }
}
