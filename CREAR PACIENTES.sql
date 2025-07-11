USE [RESIDENCIA_GERIATRICA]
GO
/****** Object:  StoredProcedure [dbo].[PA_CREAR_PACIENTES]    Script Date: 22/6/2021 19:49:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[PA_CREAR_PACIENTES]
(
@Cedula_Pac varchar(20),
@Cedula_Cont varchar(20),
@Nombre varchar(20),
@Apellidos varchar(50),
@Fecha_Nacimiento datetime,
@Tipo_Sangre varchar(3),
@Sexo char(2),
@Estado char(1)
)
AS
BEGIN
INSERT INTO [dbo].[PACIENTES]
           ([Cedula_Pac]
		   ,[Cedula_Cont]
            ,[Nombre]
           ,[Apellidos]
           ,[Fecha_Nacimiento]
           ,[Tipo_Sangre]
           ,[Sexo]
           ,[Estado])
     VALUES
           (@Cedula_Pac,	
		   @Cedula_Cont,
           @Nombre,
           @Apellidos,
           @Fecha_Nacimiento,
           @Tipo_Sangre, 
           @Sexo,
           @Estado)
END
