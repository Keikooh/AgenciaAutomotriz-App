using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAgencia
{
    public class Herramientas
    {
        public Herramientas(int codigoHerramientas, string nombre, string medida, string marca)
        {
            this.codigoHerramientas = codigoHerramientas;
            this.nombre = nombre;
            this.medida = medida;
            this.marca = marca;
        }

        public int codigoHerramientas { get; set; }
        public string nombre { get; set; }
        public string medida { get; set; }
        public string marca { get; set; }
    }
}
