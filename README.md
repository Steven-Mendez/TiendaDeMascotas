# 🐹 TiendaDeMascotas
Proyecto Final Desarrollo de Aplicaciones con C# y SQL Server

## 👨‍🎓 Datos Estudiante
- Nombre: Steven Alexander Mendez Paiz
- Correo: stevenampaiz@gmail.com

## 📓 Instruncciones
- Es necesario que crees la base de datos utilizando el scrip o el bakup que esta dentro de la carpeta base de datos.
- Deberás ingresar el siguientes script para crear un nuevo Usuario:

###
	use master
	create login ProductoMascotas with password = '123'
	go
	use MiEmpresago
	exec sp_adduser ProductoMascotas, administrador
	exec sp_addrolemember db_owner, administrador
	
- Si cambias algun nombre dentro del script anterior deberas cambiar la cadena de conexión que se encuentra en `...\TiendaDeMascotas\Modelo\Conexion.cs`

### 👷‍♂️ Usuarios del Sistema
	Usuario: admin
	Contraseña: admin
	
	Usuario: cajero
	Contraseña: cajero
	
	Usuario: recepcionista
	Contraseña: recepcionista
	
	Usuario: reportes
	Contraseña: reportes
