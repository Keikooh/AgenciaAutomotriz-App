using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ConectarBase;

namespace AccesoAgencia
{
    public class AccesoHerramientas : IEntidades
    {
        Conexion con = new Conexion("localhost", "root", "", "agenciaAutomotriz");

        public void Borrar(dynamic entidad)
        {
            con.EjecutarComando(String.Format("DELETE FROM herramientas WHERE codigoHerramientas = {0}", entidad.codigoHerramientas));
        }

        public void Guardar(dynamic entidad)
        {
            con.EjecutarComando(string.Format(" INSERT INTO herramientas VALUES (NULL,'{0}','{1}','{2}') ",
                entidad.nombre,
                entidad.medida,
                entidad.marca));
        }

        public DataSet Mostrar(string filtro)
        {
            return con.ObtenerTabla(String.Format("SELECT * FROM herramientas WHERE nombre LIKE '%{0}%' ", filtro),"herramientas");
        }
    }
}
