USE [RESIDENCIA_GERIATRICA]
GO
/****** Object:  StoredProcedure [dbo].[PA_FILTRAR_CONTACTOS]    Script Date: 22/6/2021 19:49:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[PA_FILTRAR_CONTACTOS]
(
@Nombre varchar(20)
)
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
    WHERE [Nombre] LIKE '%'+@Nombre+'%'
	END
