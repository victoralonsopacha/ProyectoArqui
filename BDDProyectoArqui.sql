create database BDDProyectoArqui
go
use BDDProyectoArqui

/*==============================================================*/
/* Table: ACTIVIDAD                                             */
/*==============================================================*/
create table ACTIVIDAD (
   ID                   int                  not null,
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
   CEDULA               int                  not null,
   ID                   int                  not null,
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
   ID                   int                  not null,
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




--PROCEDIMIENTO INSERTAR PROYECTO
CREATE PROCEDURE insertarProyecto(
@NOMBRE VARCHAR(30),
@DESCRIPCION VARCHAR(200),
@PROGRESO VARCHAR(10) 
)as
INSERT INTO PROYECTO(NOMBRE, DESCRIPCION, PROGRESO)
VALUES (@NOMBRE, @DESCRIPCION, @PROGRESO )
SELECT *FROM PROYECTO

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

