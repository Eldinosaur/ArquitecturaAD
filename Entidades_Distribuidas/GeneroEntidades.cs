using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Distribuidas
{
    public class GeneroEntidad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public GeneroEntidad()
        {

        }
        public GeneroEntidad(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }
    }
}
