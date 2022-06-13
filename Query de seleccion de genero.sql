USE [ConsultorioMedico]
GO

SELECT p.id
      ,p.[id_Genero]
      ,p.[nombre]
      ,p.[apellido]
      ,p.[cedula]
      ,p.[telefono]
      ,p.[direccion]
      ,p.[numeroIESS]
  FROM [dbo].[Paciente] p
  --inner join 

GO


