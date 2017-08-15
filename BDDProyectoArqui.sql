create database BDDProyectoArqui
go
use BDDProyectoArqui

/*==============================================================*/
/* Table: ACTIVIDAD                                             */
/*==============================================================*/
create table ACTIVIDAD (
   ID                   int      identity (1,1)            not null,
   CEDULA               int                  null,
   PRO_ID               int                  null,
   NOMBRE               varchar(50)          not null,
   ESTADO               varchar(10)          not null,
   DESCRIPCION          varchar(200)         null,
   FECHAINICIO          varchar(12)          not null,
   FECHAFIN             varchar(12)          not null,
   constraint PK_ACTIVIDAD primary key (ID)
)
go



/*==============================================================*/
/* Table: PROYECTO                                              */
/*==============================================================*/
create table PROYECTO (
   
   ID                   int      identity (1,1)             not null,
   CEDULA               int                  not null,
   NOMBRE               varchar(30)          not null,
   DESCRIPCION          varchar(200)         null,
   PROGRESO             varchar(10)          not null,
   constraint PK_PROYECTO primary key (CEDULA, ID)
)
go



/*==============================================================*/
/* Table: TAREA                                                 */
/*==============================================================*/
create table TAREA (
   ID                   int      identity (1,1)             not null,
   ACT_ID               int                  null,
   NOMBRE               varchar(50)          not null,
   ESTADO               varchar(10)          not null,
   FECHAINICIO          varchar(12)          not null,
   FECHAFIN             varchar(12)          not null,
   constraint PK_TAREA primary key (ID)
)
go


/*==============================================================*/
/* Table: USUARIO                                               */
/*==============================================================*/
create table USUARIO (
   CEDULA               int                  not null,
   NOMBRE               varchar(30)          not null,
   CONTRASEÑA           varchar(30)          not null,
   CORREO               varchar(30)          not null,
   constraint PK_USUARIO primary key (CEDULA)
)
go






alter table ACTIVIDAD
   add constraint FK_ACTIVIDA_RELATIONS_PROYECTO foreign key (CEDULA, PRO_ID)
      references PROYECTO (CEDULA, ID)
go

alter table PROYECTO
   add constraint FK_PROYECTO_RELATIONS_USUARIO foreign key (CEDULA)
      references USUARIO (CEDULA)
go

alter table TAREA
   add constraint FK_TAREA_RELATIONS_ACTIVIDA foreign key (ACT_ID)
      references ACTIVIDAD (ID)
go


--PROCEDIMIENTOS ALMACENADOS


--PROCEDIMIENTO PARA REGISTRAR USUARIO
create PROCEDURE registrarUsuario
@cedula int,
@nombre varchar(30),
@contraseña varchar(30),
@correo varchar(30)
as
insert into USUARIO(cedula,nombre,contraseña,correo)
values (@cedula,@nombre,@contraseña,@correo)

--PROCEDIMIENTO PARA LOGIN USUARIO
create procedure LOGINUSUARIO
@NOMBRE varchar(30),
@CONTRASEÑA varchar(30)
AS
SELECT NOMBRE, CONTRASEÑA, CEDULA  FROM USUARIO
WHERE NOMBRE = @NOMBRE AND CONTRASEÑA  =@CONTRASEÑA


--PROCEDIMIENTO ACTUALIZAR USUARIO
create procedure actualizarUsuario
@cedula int,
@nombre varchar(30),
@contraseña varchar(30),
@correo varchar(30)
as
update USUARIO 
set nombre=@nombre,contraseña=@contraseña,correo=@correo
where cedula=@cedula

select * from usuario



--PROCEDIMIENTO BUSCARUSUARIO

CREATE PROCEDURE buscarUsuario 
@cedula int 
AS
select * from USUARIO
WHERE cedula= @cedula
exec buscarUsuario 1723427207


select * from usuario
select * from proyecto

--PROCEDIMIENTO INSERTAR PROYECTO
create PROCEDURE insertarProyecto(
@CEDULA int,
@NOMBRE VARCHAR(30),
@DESCRIPCION VARCHAR(200),
@PROGRESO VARCHAR(10)

)as
INSERT INTO PROYECTO(CEDULA,NOMBRE, DESCRIPCION, PROGRESO)
VALUES (@CEDULA,@NOMBRE, @DESCRIPCION, @PROGRESO )
SELECT *FROM PROYECTO

exec insertarProyecto 1723427207,'Proyecto arquitectura web','final de semestre','start'

--PROCEDIMIENTO CONSULTAR PROYECTO
CREATE PROCEDURE consultarProyectos
	AS
	SELECT * FROM PROYECTO

--PROCEDIMIENTO CONSULTAR POR ID
CREATE PROCEDURE consultarProyectoPorID 
		@ID int 
	AS
	SELECT * FROM PROYECTO 
	WHERE ID= @ID

--PROCEDIMIENTO ACTUALIZAR PROYECTO
CREATE PROCEDURE actualizarProyecto(
@ID INT,
@NOMBRE VARCHAR(30),
@DESCRIPCION VARCHAR(200),
@PROGRESO VARCHAR(10) 
)as
UPDATE PROYECTO SET NOMBRE= @NOMBRE, DESCRIPCION= @DESCRIPCION, PROGRESO=@PROGRESO
WHERE ID= @ID
SELECT *FROM PROYECTO

--PROCEDIMIENTO ELIMINAR PROYECTO
CREATE PROCEDURE eliminarProyecto
(@ID  int)
AS DELETE PROYECTO WHERE  ID =@ID

<<<<<<< HEAD
--PROCEDIMIENTO ASIGNAR_TAREA_A_ACTIVIDAD
alter procedure insertarTareaEnActividad

@ACT_ID int,
@NOMBRE varchar(50),
@ESTADO varchar(10),
@FECHAINICIO varchar(12),
@FECHAFIN varchar(12)
as
insert into TAREA(ACT_ID,NOMBRE,ESTADO,FECHAINICIO,FECHAFIN)
values(@ACT_ID,@NOMBRE,@ESTADO,@FECHAINICIO,@FECHAFIN)

select * from USUARIO
select * from PROYECTO
select * from ACTIVIDAD
select * from TAREA

exec insertarTareaEnActividad 1,'pensar el el modelo entidad','start','08/08/2017','09/08/2017'

=======
--PROCEDIMIENTO INSERTAR ACTIVIDAD
CREATE PROCEDURE insertarActividad(
@CEDULA int,
@PRO_ID int,
@NOMBRE VARCHAR(30),
@ESTADO VARCHAR(200),
@DESCRIPCION VARCHAR(200),
@FECHAINICIO VARCHAR(10),
@FECHAFIN VARCHAR(10)
)as
INSERT INTO ACTIVIDAD(CEDULA,PRO_ID,NOMBRE,ESTADO, DESCRIPCION, FECHAINICIO,FECHAFIN)
VALUES (@CEDULA,@PRO_ID,@NOMBRE,@ESTADO, @DESCRIPCION, @FECHAINICIO, @FECHAFIN )

SELECT *FROM ACTIVIDAD

--PROCEDIMIENTO ELIMINAR ACTIVIDAD
CREATE PROCEDURE eliminarActividad
(@ID  int)
AS DELETE ACTIVIDAD WHERE  ID =@ID

--PROCEDIMIENTO CONSULTAR POR ID ACTIVIDAD
CREATE PROCEDURE consultarActividadPorID 
		@ID int 
	AS
	SELECT * FROM ACTIVIDAD 
	WHERE ID= @ID
	
	
--PROCEDIMIENTO PARA BUSCAR EL ID DEL PROYECTO POR LA CEDULA DEL USUARIO
CREATE PROC buscarIdProyectoPorCedula
@CEDULA int
AS
SELECT ID FROM PROYECTO
WHERE CEDULA=@CEDULA

EXEC buscarIdProyectoPorCedula 1717267593
>>>>>>> bb854cac7154d969b520217b0d7f3c001c8eaf8d
