USE [RESIDENCIA_GERIATRICA]
GO
/****** Object:  StoredProcedure [dbo].[PA_CONSULTAR_CONTACTOS]    Script Date: 22/6/2021 19:47:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[PA_CONSULTAR_CONTACTOS]
AS
BEGIN
SELECT [Cedula_Cont]
      ,[Nombre]
      ,[Apellidos]
      ,[Direccion]
      ,[Telefono]
      ,[Correo_Electronico]
      ,[Sexo]
      ,[Estado]
  FROM [dbo].[CONTACTOS]
  END
