using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ConectarBase;

namespace AccesoAgencia
{
    public class AccesoProductos : IEntidades
    {
        Conexion con = new Conexion("localhost", "root", "", "agenciaAutomotriz");

        public void Guardar(dynamic entidad)
        {
            con.EjecutarComando(string.Format(" INSERT INTO productos VALUES (NULL,'{0}','{1}','{2}') ",
                entidad.nombre,
                entidad.descripcion,
                entidad.marca));
        }
    }
}
