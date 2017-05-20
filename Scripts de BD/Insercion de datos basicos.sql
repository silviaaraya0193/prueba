/*---------------Carga de datos basicos para el sistema--------------*/

use Laboratorio
go

insert into TB_USUARIO (CODIGO_USUARIO,LOGIN_USUARIO,NOMBRE,PASSWORD_USUARIO,PERFIL) values(1,'admin','Administrador','123','DBA');

insert into TB_ROLE (CODIGO_ROLE,NOMBRE) values(1,'DBA');
insert into TB_VISTAS(ID_VISTA,NOMBRE_VISTA) values(1,'Vista_Usuario');
insert into TB_VISTAS(ID_VISTA,NOMBRE_VISTA) values(2,'Vista_Permisos');
insert into TB_VISTAS(ID_VISTA,NOMBRE_VISTA) values(3,'Vista_Roles');
insert into TB_VISTAS(ID_VISTA,NOMBRE_VISTA) values(4,'Vista_Vistas');

insert into TB_ROLE_USUARIO(CODIGO_ROLE,CODIGO_USUARIO) values(1,1);
insert into TB_PERMISOS(CODIGO_PERMISO,CODIGO_VISTA,SELECCION,INSERCION,ACTUALIZACION,BORRADO) values(1,1,'true','true','true','true');
insert into TB_PERMISOS(CODIGO_PERMISO,CODIGO_VISTA,SELECCION,INSERCION,ACTUALIZACION,BORRADO) values(2,2,'true','true','true','true');
insert into TB_PERMISOS(CODIGO_PERMISO,CODIGO_VISTA,SELECCION,INSERCION,ACTUALIZACION,BORRADO) values(3,3,'true','true','true','true');
insert into TB_PERMISOS(CODIGO_PERMISO,CODIGO_VISTA,SELECCION,INSERCION,ACTUALIZACION,BORRADO) values(4,4,'true','true','true','true');

insert into TB_PERMISO_ROLE(CODIGO_ROLE,CODIGO_PERMISO) values(1,1);
insert into TB_PERMISO_ROLE(CODIGO_ROLE,CODIGO_PERMISO) values(1,2);
insert into TB_PERMISO_ROLE(CODIGO_ROLE,CODIGO_PERMISO) values(1,3);
insert into TB_PERMISO_ROLE(CODIGO_ROLE,CODIGO_PERMISO) values(1,4);