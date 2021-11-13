create database CxC

use CxC

create table Tipos_Documentos(
Id int IDENTITY(1,1) PRIMARY KEY,
Descripcion varchar(100),
Cuenta_contable varchar(20) not null,
Estado varchar(1) not null
)

create table Clientes(
Id int IDENTITY(1,1) PRIMARY KEY,
Nombre varchar(50),
Cédula varchar(11) unique not null,
Limite_credit int not null,
Estado varchar(1) not null
)


create table Transacciones(
Id int IDENTITY(1,1) PRIMARY KEY,
Id_transaccion varchar(15) unique not null,
Tipo_Mov varchar(2) not null,
TipoDoc_ID int foreign key references Tipos_Documentos(Id) not null,
Num_doc varchar(50) not null,
Fecha date not null,
Cliente_ID int foreign key references Clientes(Id) not null,
Monto int not null
)

create table Asientos(
Id int IDENTITY(1,1) PRIMARY KEY,
Id_Asiento varchar(15) unique not null,
Descripcion varchar(100),
Cliente_ID int foreign key references Clientes(Id) not null,
Cuenta varchar(50),
Tipo_movimiento varchar(2) not null,
Fecha date not null,
Monto int not null,
Estado varchar(1) not null
)

create table Users(
Id int IDENTITY(1,1) PRIMARY KEY,
Usuario varchar(10) unique not null,
Contraseña varchar(25) not null
)