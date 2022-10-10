using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EntidadesAgencia;
using ConectarBase;
using System.Data;

namespace AccesoAgencia
{
    public class AccesoUsuario
    {
        Conexion con = new Conexion("Localhost","root","", "agenciaAutomotriz");

        public dynamic VerificarUsuario(Usuario usuario)
        {
            return con.ObtenerDato( string.Format("SELECT * FROM usuarios WHERE nickname = '{0}' AND passwrd = '{1}'", usuario.nickname, usuario.password));
        }

    }
}
