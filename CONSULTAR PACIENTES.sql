USE [RESIDENCIA_GERIATRICA]
GO
/****** Object:  StoredProcedure [dbo].[PA_CONSULTAR_PACIENTES]    Script Date: 22/6/2021 19:48:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[PA_CONSULTAR_PACIENTES]
AS
BEGIN
SELECT [Cedula_Pac]
      ,[Cedula_Cont]
      ,[Nombre]
      ,[Apellidos]
      ,[Fecha_Nacimiento]
      ,[Tipo_Sangre]
      ,[Sexo]
      ,[Estado]
  FROM [dbo].[PACIENTES]
END
