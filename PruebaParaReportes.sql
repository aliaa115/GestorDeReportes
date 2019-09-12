CREATE DATABASE PruebasReportes CHARACTER SET UTF8;
USE PruebasReportes;


-- Creacion de Tablas

create table Empleado (
	codigoEmpleado int,
	nombreEmpleado varchar(20),
	apellidoEmpleado varchar(20)
);

create table Cliente (
	codigoCliente int,
    nombreCliente varchar(20),
    apellidoCliente varchar(20)
);

create table Habitacion (
	codigoArea varchar(1),
    numeroPiso int,
    numeroHabitacion int,
    tipo varchar(20)
);

create table Renta(
	codigoRenta int,
    codigoCliente int,
    codigoArea varchar(1),
    numeroPiso int,
    numeroHabitacion int,
    fechaEntrada datetime,
    fechaSalida datetime,
    codigoEmpleado int
);


-- creacion de llaves Primarias

alter table Empleado add constraint PK_Empleado Primary key (codigoEmpleado);
alter table Cliente add constraint PK_Cliente Primary key (codigoCliente);
alter table Habitacion add constraint PK_Habitacion Primary key (codigoArea, numeroPiso, numeroHabitacion);
alter table Renta add constraint PK_Renta primary key (codigoRenta, codigoCliente, codigoArea, numeroPiso, numeroHabitacion);


-- Creacion de llavers Foraneas

alter table Renta add constraint FK_Renta_Cliente Foreign key (codigoCliente) references Cliente (codigoCliente);
alter table Renta add constraint FK_Renta_Habitac Foreign key (codigoArea, numeroPiso, numeroHabitacion) references Habitacion(codigoArea, numeroPiso, numeroHabitacion);
alter table Renta add constraint FK_Renta_Empleado Foreign key (codigoEmpleado) references Empleado (codigoEmpleado);

