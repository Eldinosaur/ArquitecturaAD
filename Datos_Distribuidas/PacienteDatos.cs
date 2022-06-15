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
                                                ,[direccion]
                                                ,[numeroIESS])
                                                VALUES
                                                (@nombre, @apellido, @cedula, @telefono, @direccion, @numeroIESS);
                                                SELECT SCOPE_IDENTITY()";
                cmd.Parameters.AddWithValue("@nombre", pacienteEntidad.Nombre);
                cmd.Parameters.AddWithValue("@apellido", pacienteEntidad.Apellido);
                cmd.Parameters.AddWithValue("@cedula", pacienteEntidad.Cedula);
                cmd.Parameters.AddWithValue("@telefono", pacienteEntidad.Telefono);
                cmd.Parameters.AddWithValue("@direccion", pacienteEntidad.Direccion);
                cmd.Parameters.AddWithValue("@numeroIESS", pacienteEntidad.NumeroIESS);

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
                                      ,[numeroIESS] =@numeroIESS
                                       WHERE id = @id";
                cmd.Parameters.AddWithValue("@nombre", pacienteEntidad.Nombre);
                cmd.Parameters.AddWithValue("@apellido", pacienteEntidad.Apellido);
                cmd.Parameters.AddWithValue("@cedula", pacienteEntidad.Cedula);
                cmd.Parameters.AddWithValue("@telefono", pacienteEntidad.Telefono);
                cmd.Parameters.AddWithValue("@direccion", pacienteEntidad.Direccion);

                cmd.Parameters.AddWithValue("@numeroIESS", pacienteEntidad.NumeroIESS);
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

                cmd.CommandText = @"SELECT p.[id]
                                  ,p.[nombre]
	                              ,g.nombre genero
                                  ,p.[apellido]
                                  ,p.[cedula]
                                  ,p.[telefono]
                                  ,p.[direccion]
                                  ,p.[numeroIESS]
                              FROM [dbo].[Paciente] p
                              inner join [dbo].[Genero] g on id_Genero=g.id";

                //using lo que se usa se libera de memoria despues de la ejecucion
                using (var dr = cmd.ExecuteReader()) //dr data reader para leer los datos de la base
                {
                    while (dr.Read())
                    {
                        PacienteEntidad paciente = new PacienteEntidad();
                        paciente.Id = Convert.ToInt32( dr["id"].ToString());
                        paciente.Nombre = dr["nombre"].ToString();
                        paciente.Apellido = dr["apellido"].ToString();
                        paciente.Genero = dr["genero"].ToString();
                        paciente.Cedula = dr["cedula"].ToString();
                        paciente.Telefono = dr["telefono"].ToString();
                        paciente.Direccion = dr["direccion"].ToString();
                        paciente.NumeroIESS = dr["numeroIESS"].ToString();
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
        public static PacienteEntidad DevolverPacientePorID(int idPaciente)
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
                                      ,[numeroIESS]
                                    FROM[dbo].[Paciente]
                                          WHERE id=@id";
                ;

                cmd.Parameters.AddWithValue("@id", idPaciente);
                using (var dr = cmd.ExecuteReader())
                {
                    dr.Read();
                    if (dr.HasRows)
                    {
                        paciente.Id = Convert.ToInt32(dr["id"].ToString());
                        paciente.Nombre = dr["nombre"].ToString();
                        paciente.Apellido = dr["apellido"].ToString();
                        paciente.Cedula = dr["cedula"].ToString();
                        paciente.Telefono = dr["telefono"].ToString();
                        paciente.Direccion = dr["direccion"].ToString();
                        paciente.NumeroIESS = dr["numeroIESS"].ToString();
                    }
                }//se libera de memoria al terminar

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
