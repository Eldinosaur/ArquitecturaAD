using System;
using System.Collections.Generic;
using Entidades_Distribuidas;
using System.Data;
using System.Data.SqlClient;

namespace Datos_Distribuidas
{
    public static class PacienteDatos
    {
      public static List<GeneroEntidad> DevolverListaGeneros()
        {
            try
            {
                List<GeneroEntidad> listaGeneros = new List<GeneroEntidad>();
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = @"SELECT [id]
                                           ,[nombre]
                                      FROM [dbo].[Genero]";
                using (var dr = cmd.ExecuteReader()) //dr data reader para leer los datos de la base
                {
                    while (dr.Read())
                    {
                        GeneroEntidad genero = new GeneroEntidad();
                        genero.Id = Convert.ToInt32(dr["id"].ToString());
                        genero.Nombre = dr["nombre"].ToString();
                        listaGeneros.Add(genero);
                    }

                }
                conexion.Close();
                return listaGeneros;
            }
            catch (Exception)
            {

                throw;
            }
        }
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
                                                ([id_Genero]
                                                ,[nombre]
                                                ,[apellido]
                                                ,[cedula]
                                                ,[telefono]
                                                ,[direccion]
                                                ,[numeroIESS])
                                                VALUES
                                                (@id_Genero, @nombre, @apellido, @cedula, @telefono, @direccion, @numeroIESS);
                                                SELECT SCOPE_IDENTITY()";
                cmd.Parameters.AddWithValue("@id_Genero",pacienteEntidad.IdGenero);
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
                                   SET [id_Genero] = @id_Genero 
                                      ,[nombre] = @nombre
                                      ,[apellido] = @apellido
                                      ,[cedula] = @cedula
                                      ,[telefono] = @telefono
                                      ,[direccion] = @direccion
                                      ,[numeroIESS] =@numeroIESS
                                       WHERE id = @id";
                cmd.Parameters.AddWithValue("@id_Genero", pacienteEntidad.IdGenero);
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
                                  ,p.[id_Genero]
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
                        paciente.IdGenero = Convert.ToInt32(dr["id_Genero"].ToString());
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
                cmd.CommandText = @"SELECT p.[id]
                                  ,p.[id_Genero]
                                  ,p.[nombre]
	                              ,g.nombre genero
                                  ,p.[apellido]
                                  ,p.[cedula]
                                  ,p.[telefono]
                                  ,p.[direccion]
                                  ,p.[numeroIESS]
                              FROM [dbo].[Paciente] p
                              inner join [dbo].[Genero] g on id_Genero=g.id
                                          WHERE p.id=@id";
                ;

                cmd.Parameters.AddWithValue("@id", idPaciente);
                using (var dr = cmd.ExecuteReader())
                {
                    dr.Read();
                    if (dr.HasRows)
                    {
                        paciente.Id = Convert.ToInt32(dr["id"].ToString());
                        paciente.IdGenero = Convert.ToInt32(dr["id_Genero"].ToString());
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
        public static bool EliminarPaciente(int identificador)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM[dbo].[Paciente] WHERE id =@id";
                cmd.Parameters.AddWithValue("@id", identificador);
                var filasAfectadas = Convert.ToInt32(cmd.ExecuteNonQuery());
                conexion.Close();
                if (filasAfectadas > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception)
            {
                
               throw;
            }
        }
    }
}
