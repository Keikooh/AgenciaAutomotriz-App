using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoAgencia
{
    public interface IEntidades
    {
        void Guardar(dynamic entidad);
        void Borrar(dynamic entidad);
        DataSet Mostrar(string filtro);

    }
}
