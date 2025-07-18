USE [RESIDENCIA_GERIATRICA]
GO
/****** Object:  StoredProcedure [dbo].[PA_MODIFICAR_PACIENTES]    Script Date: 22/6/2021 19:50:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[PA_MODIFICAR_PACIENTES]
(
@Cedula_Pac varchar(20),
@Cedula_Cont varchar(20),
@Nombre varchar(20),
@Apellidos varchar(50),
@Fecha_Nacimiento datetime,
@Tipo_Sangre varchar(3),
@Sexo char(1),
@Estado char(1)
)
AS
BEGIN
UPDATE [dbo].[PACIENTES]
   SET [Cedula_Pac] = @Cedula_Pac
      ,[Cedula_Cont] = @Cedula_Cont
      ,[Nombre] = @Nombre
      ,[Apellidos] = @Apellidos
      ,[Fecha_Nacimiento] = @Fecha_Nacimiento
      ,[Tipo_Sangre] = @Tipo_Sangre
      ,[Sexo] = @Sexo
      ,[Estado] = @Estado
 WHERE [Cedula_Pac]=@Cedula_Pac
 END
