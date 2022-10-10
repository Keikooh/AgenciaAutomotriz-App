using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ConectarBase;

namespace AccesoAgencia
{
    public class AccesoHerramientas : IEntidades
    {
        Conexion con = new Conexion("localhost", "root", "", "agenciaAutomotriz");
        public void Guardar(dynamic entidad)
        {
            con.EjecutarComando(string.Format(" INSERT INTO herramientas VALUES (NULL,'{0}','{1}','{2}') ",
                entidad.nombre,
                entidad.medida,
                entidad.marca));
        }
    }
}
