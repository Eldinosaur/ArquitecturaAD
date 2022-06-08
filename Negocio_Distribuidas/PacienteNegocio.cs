using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades_Distribuidas;
using Datos_Distribuidas;

namespace Negocio_Distribuidas
{
    public static class PacienteNegocio
    {
        public static PacienteEntidad GuardarPacienteNegocio(PacienteEntidad pacienteEntidad)
        {
            if (pacienteEntidad.Id == 0)
            {
                //vamos a crear un nuevo paciente
                return PacienteDatos.Nuevo(pacienteEntidad);
            }
            else
            {
                //vamos a actualizar al paciente
                return PacienteDatos.Actualizar(pacienteEntidad);
            }
        }
    }
}
