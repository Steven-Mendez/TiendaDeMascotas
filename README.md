# TiendaDeMascotas
Proyecto Final Desarrollo de Aplicaciones con C# y SQL Server

* Datos Estudiante
	Nombre: Steven Alexander Mendez Paiz
	Correo: stevenampaiz@gmail.com
* Usuario SQLSERVER

use master
create login ProductoMascotas with password = '123'
go
use MiEmpresa
go
exec sp_adduser ProductoMascotas, administrador
exec sp_addrolemember db_owner, administrador

* Usuarios del Sistema

usuario contraseña
- admin 123
- cajero cajero
- recepcionista recepcionista
- reportes reportes
