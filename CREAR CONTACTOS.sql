USE [RESIDENCIA_GERIATRICA]
GO
/****** Object:  StoredProcedure [dbo].[PA_CREAR_CONTACTOS]    Script Date: 22/6/2021 19:49:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[PA_CREAR_CONTACTOS]
(
@Cedula_Cont varchar(20),
@Nombre varchar(20),
@Apellidos varchar(20),
@DirecciOn varchar(150),
@Telefono varchar(9),
@Correo_Electronico varchar(50),
@sexo char(1),
@Estado char(1)
)
AS
BEGIN
INSERT INTO [dbo].[CONTACTOS]
           ([Cedula_Cont]
           ,[Nombre]
           ,[Apellidos]
           ,[Direccion]
           ,[Telefono]
           ,[Correo_Electronico]
           ,[Sexo]
           ,[Estado])
     VALUES
           (@Cedula_Cont,
           @Nombre, 
           @Apellidos, 
           @Direccion, 
           @Telefono, 
           @Correo_Electronico,
           @Sexo,
           @Estado)

		END
