using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAgencia
{
    public class Productos
    {
        public Productos(int codigoBarras, string nombre, string descripcion, string marca)
        {
            this.codigoBarras = codigoBarras;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.marca = marca;
        }

        public int codigoBarras { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string marca { get; set; }
    }
}
