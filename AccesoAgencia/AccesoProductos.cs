using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ConectarBase;

namespace AccesoAgencia
{
    public class AccesoProductos : IEntidades
    {
        Conexion con = new Conexion("localhost", "root", "", "agenciaAutomotriz");

        public void Borrar(dynamic entidad)
        {
            con.EjecutarComando(String.Format("DELETE FROM productos WHERE codigoBarras = {0}", entidad.codigoBarras));
        }

        public void Guardar(dynamic entidad)
        {
            con.EjecutarComando(string.Format("INSERT INTO productos VALUES (NULL,'{0}','{1}','{2}') ",
                entidad.nombre,
                entidad.descripcion,
                entidad.marca));
        }

        public DataSet Mostrar(string filtro)
        {
            return con.ObtenerTabla(String.Format("SELECT * FROM productos WHERE nombre LIKE '%{0}%'",filtro), "productos");
        }
    }
}
