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
            catch(Exception e)
            {
                string error = e.Message;
                throw;
            }
        }
        public static PacienteEntidad Actualizar(PacienteEntidad pacienteEntidad)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = @"UPDATE [dbo].[Paciente]
                                   SET [nombre] = @nombre
                                      ,[apellido] = @apellido
                                      ,[cedula] = @cedula
                                      ,[telefono] = @telefono
                                      ,[direccion] = @direccion
                                       WHERE id = @id";
                cmd.Parameters.AddWithValue("@nombre", pacienteEntidad.Nombre);
                cmd.Parameters.AddWithValue("@apellido", pacienteEntidad.Apellido);
                cmd.Parameters.AddWithValue("@cedula", pacienteEntidad.Cedula);
                cmd.Parameters.AddWithValue("@telefono", pacienteEntidad.Telefono);
                cmd.Parameters.AddWithValue("@direccion", pacienteEntidad.Direccion);
                cmd.Parameters.AddWithValue("@id", pacienteEntidad.Id);

                cmd.ExecuteNonQuery();

                conexion.Close();

                return pacienteEntidad;
            }
            catch (Exception e)
            {
                string error = e.Message;
                throw;
            }
        }

        public static List<PacienteEntidad> DevolverListadoPacientes()
        {
            try
            {
                List<PacienteEntidad> listaPacientes = new List<PacienteEntidad>();
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = @"SELECT [id]
                                      ,[nombre]
                                      ,[apellido]
                                      ,[cedula]
                                      ,[telefono]
                                      ,[direccion]
                                  FROM [dbo].[Paciente]";

                //using lo que se usa se libera de memoria despues de la ejecucion
                using (var dr = cmd.ExecuteReader()) //dr data reader para leer los datos de la base
                {
                    while (dr.Read())
                    {
                        PacienteEntidad paciente = new PacienteEntidad();
                        paciente.Id = Convert.ToInt32( dr["id"].ToString());
                        paciente.Nombre = dr["nombre"].ToString();
                        paciente.Apellido = dr["apellido"].ToString();
                        paciente.Cedula = dr["cedula"].ToString();
                        paciente.Telefono = dr["telefono"].ToString();
                        paciente.Direccion = dr["direccion"].ToString();
                        listaPacientes.Add(paciente);
                    }
                }
                conexion.Close();
                return listaPacientes;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static PacienteEntidad DevolverPacientePorID(int IdPaciente)
        {
            try
            {
                PacienteEntidad paciente = new PacienteEntidad();
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = @"SELECT [id]
                                      ,[nombre]
                                      ,[apellido]
                                      ,[cedula]
                                      ,[telefono]
                                      ,[direccion]
                                  FROM [dbo].[Paciente]
                                  WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", IdPaciente);
                using (var dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        paciente.Id = Convert.ToInt32(dr["id"].ToString());
                        paciente.Nombre = dr["nombre"].ToString();
                        paciente.Apellido = dr["apellido"].ToString();
                        paciente.Cedula = dr["cedula"].ToString();
                        paciente.Telefono = dr["telefono"].ToString();
                        paciente.Direccion = dr["direccion"].ToString();
                    }
                }
                conexion.Close();
                return paciente;
            }
            catch (Exception)
            {

                throw;
            }
           
            
        }
    }
}
