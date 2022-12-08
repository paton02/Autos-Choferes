create database AutosChoferes
create table Autos
(
	id_auto int identity (1,1) not null,
	marca varchar(30) not null,
	modelo varchar (30) not null,
	anio int not null,
	patente varchar(10) unique,

	constraint pk_id_autos primary key(id_auto),
	check (anio>=2005)
)
create table DatosPersonales
(
	id_DatosPersonales int identity (1,1) not null,
	nombre varchar(35) not null,
	apellido varchar(30) not null,
	email varchar(50) not null,
	telefono varchar (25) not null,
	dni varchar(15) not null unique,

	constraint pk_DatosPersonales primary key (id_DatosPersonales)
)
create table Clientes
(
	id_Clientes int identity(1,1) not null,
	id_Datos_Personales int not null

	constraint pk_id_Clientes primary key (id_Clientes),
	constraint fk_id_Datos_Pesonales foreign key(id_Datos_Personales) references DatosPersonales (id_DatosPersonales)
)
create table TipoRegistros
(
	id_Tipo int identity(1,1) not null,
	tipo varchar(10) not null unique,

	constraint id_Tipo primary key (id_Tipo)
)
create table Registro
(
	id_Registros int identity (1,1) not null,
	id_TipoRegistro int not null,
	Fecha_Vencimiento varchar(10) not null,

	constraint pk_id_Registros primary key(id_Registros),
	constraint fk_id_TipoRegistro foreign key (id_TipoRegistro) references TipoRegistros (id_Tipo)
)

create table Empleados
(
	id_Empleados int identity (1,1) not null,
	id_Autos int not null,
	id_DatosPersonales int not null,
	id_Registro int not null,

	constraint pk_id_Empleado primary key (id_Empleados),
	constraint fk_id_Autos foreign key (id_Autos) references Autos(id_auto),
	constraint fk_DatosPersonales foreign key(id_DatosPersonales) references DatosPersonales(id_DatosPersonales),
	constraint fk_Registro foreign key (id_Registro) references Registro (id_Registros)
)
select dni from DatosPersonales 