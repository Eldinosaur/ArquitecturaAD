using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Distribuidas
{
    public class PacienteEntidad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string NumeroIESS { get; set; }
        public string Genero { get; set; }
        public int IdGenero { get; set; }
        public PacienteEntidad()
        {
        }
        public PacienteEntidad(int id, string nombre, string apellido, string genero, int idgenero,
            string cedula, string telefono, string direccion, string numeroIESS)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            IdGenero = idgenero;
            Genero = genero;
            Cedula = cedula;
            Telefono = telefono;
            Direccion = direccion;
            NumeroIESS = numeroIESS;
        }
    }
}
