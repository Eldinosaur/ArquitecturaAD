using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades_Distribuidas;
using System.Data;
using System.Data.SqlClient;

namespace Datos_Distribuidas
{
    public static class PacienteDatos
    {
        public static PacienteEntidad Nuevo(PacienteEntidad pacienteEntidad)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = @"INSERT INTO [dbo].[Paciente]
                                                ([nombre]
                                                ,[apellido]
                                                ,[cedula]
                                                ,[telefono]
                                                ,[direccion])
                                                VALUES
                                                (@nombre, @apellido, @cedula, @telefono, @direccion);
                                                SELECT SCOPE_IDENTITY()";
                cmd.Parameters.AddWithValue("@nombre", pacienteEntidad.Nombre);
                cmd.Parameters.AddWithValue("@apellido", pacienteEntidad.Apellido);
                cmd.Parameters.AddWithValue("@cedula", pacienteEntidad.Cedula);
                cmd.Parameters.AddWithValue("@telefono", pacienteEntidad.Telefono);
                cmd.Parameters.AddWithValue("@direccion", pacienteEntidad.Direccion);

                int IdPaciente=Convert.ToInt32(cmd.ExecuteScalar());
                pacienteEntidad.Id = IdPaciente;

                conexion.Close();

                return pacienteEntidad;
            }
            catch(Exception)
            {
                throw;
            }
        }
        public static PacienteEntidad Actualizar(PacienteEntidad pacienteEntidad)
        {
            //TODO: se debe programar la actualizacion del paciente
            return null;
        }
    }
}
