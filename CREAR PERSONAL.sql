USE [RESIDENCIA_GERIATRICA]
GO
/****** Object:  StoredProcedure [dbo].[PA_CREAR_PERSONAL]    Script Date: 22/6/2021 19:49:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [dbo].[PA_CREAR_PERSONAL]
(
@Cedula_Per varchar(20),
@Password varchar(8),
@Nombre varchar(20),
@Apellidos varchar(50),
@DirecciOn varchar(150),
@Telefono varchar(9),
@Correo_Electronico varchar(50),
@sexo char(1),
@Estado char(1),
@cargo varchar(50)

)
AS
BEGIN
INSERT INTO [dbo].[PERSONAL]
           ([Cedula_Per]
           ,[Password]
           ,[Nombre]
           ,[Apellidos]
           ,[Direccion]
           ,[Telefono]
           ,[Correo_Electronico]
           ,[Sexo]
           ,[Estado]
		   ,[Cargo])
     VALUES
           (@Cedula_Per,
		   @Password,
           @Nombre, 
           @Apellidos, 
           @Direccion, 
           @Telefono, 
           @Correo_Electronico,
           @Sexo,
           @Estado,
		   @Cargo)
		   END
