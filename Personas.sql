CREATE TABLE PERSONAS (
	ID_PERSONAS INT PRIMARY KEY IDENTITY(1,1),
	Nombre varchar(50),
	Apellidos varchar(150),
	NIF varchar(11) unique,
	Dirección varchar(500),
	Ciudad varchar(20),
	Estado_Civil  varchar(10),
	Sexo varchar(10),
	Código_Postal int,
	Provincia varchar(30)
	)
