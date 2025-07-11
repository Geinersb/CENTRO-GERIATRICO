USE [RESIDENCIA_GERIATRICA]
GO
/****** Object:  StoredProcedure [dbo].[PA_FILTRAR_PERSONAL]    Script Date: 22/6/2021 19:50:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PA_FILTRAR_PERSONAL]
(
@Nombre varchar(50)
)
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
	  [Cargo]
  FROM [dbo].[PERSONAL]

 WHERE [Nombre] LIKE '%'+@Nombre+'%'
  END
