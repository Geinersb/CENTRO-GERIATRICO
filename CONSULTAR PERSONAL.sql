USE [RESIDENCIA_GERIATRICA]
GO
/****** Object:  StoredProcedure [dbo].[PA_CONSULTAR_PERSONAL]    Script Date: 22/6/2021 19:48:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[PA_CONSULTAR_PERSONAL]
AS
BEGIN
SELECT [Cedula_Per]
      ,[Password]
      ,[Nombre]
      ,[Apellidos]
      ,[Direccion]
      ,[Telefono]
      ,[Correo_Electronico]
      ,[Sexo]
      ,[Estado]
	  ,[Cargo]
  FROM [dbo].[PERSONAL]
  END
