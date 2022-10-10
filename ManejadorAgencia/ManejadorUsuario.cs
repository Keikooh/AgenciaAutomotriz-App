using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EntidadesAgencia;
using AccesoAgencia;
using System.Data;

namespace ManejadorAgencia
{
    public class ManejadorUsuario
    {
        AccesoUsuario au = new AccesoUsuario();

        public dynamic VerificarUsuario(Usuario usuario)
        {
            return au.VerificarUsuario(usuario);
        }
    }
}
