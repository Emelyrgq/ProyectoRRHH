CREATE TABLE rol(
	id SERIAL,
	descripcion varchar(50),
	CONSTRAINT pk_rol_id PRIMARY KEY (id)
);


CREATE TABLE usuarios(
	id SERIAL,
	nombre varchar(50),
	correo varchar(50),
	clave varchar(50),
	CONSTRAINT pk_usuarios_id PRIMARY KEY (id),
	idRol int references rol(id)
);


CREATE TABLE competencias(
	id SERIAL,
	descripcion VARCHAR(100),
	estado BOOLEAN,
	CONSTRAINT pk_competencia_id PRIMARY KEY (id),
	CONSTRAINT uq_competencias_descripcionCompetencia UNIQUE (descripcion)
);

CREATE TABLE idiomas(
	id SERIAL,
	nombre VARCHAR(20),
	nivel VARCHAR(20),
	CONSTRAINT pk_idiomas_id PRIMARY KEY (id),
	CONSTRAINT uq_idiomas_nombre UNIQUE (nombre)
);

CREATE TABLE capacitaciones(
	id SERIAL,
	descripcion VARCHAR(100),
	nivel VARCHAR(20),
	fechaDesde DATE,
	fechaHasta DATE,
	institucion VARCHAR(50),
	CONSTRAINT pk_capacitacion_id PRIMARY KEY (id),
	CONSTRAINT uq_capacitaciones_descripcionCapacitacion UNIQUE (descripcion)
);

CREATE TABLE puestos(
	id SERIAL,
	nombre VARCHAR(50),
	nivelRiesgo VARCHAR(10),
	salarioMin VARCHAR(20),
	salarioMax VARCHAR(20),
	estado BOOLEAN,
	CONSTRAINT pk_puesto_id PRIMARY KEY (id),
	CONSTRAINT uq_puestos_nombre UNIQUE (nombre)
);

CREATE TABLE departamentos(
	id SERIAL,
	departamento VARCHAR(50),
	CONSTRAINT pk_departamento_id PRIMARY KEY (id),
	CONSTRAINT uq_departamentos_departamento UNIQUE (departamento)
);

CREATE TABLE expLaboral(
	id SERIAL,
	empresa VARCHAR(100),
	puestoOcupado VARCHAR(100),
	fechaDesde DATE,
	fechaHasta DATE,
	salario VARCHAR(20),
	CONSTRAINT pk_expLaboral_id PRIMARY KEY (id),
	CONSTRAINT uq_explaboral_empresa UNIQUE (empresa)
);

CREATE TABLE candidatos(
	id SERIAL,
	cedula VARCHAR(30),
	nombre VARCHAR(60),
	puestoAspira VARCHAR(50),
	departamento VARCHAR(30),
	salarioAspira VARCHAR(10),
	competencias VARCHAR(60),
	capacitaciones VARCHAR(60),
	expLaboral VARCHAR(50),
	recomendadoPor VARCHAR(60),
	CONSTRAINT pk_candidatos_id PRIMARY KEY (id),
	CONSTRAINT uq_candidatos_cedula UNIQUE (cedula),
	CONSTRAINT fk_candidatos_puestoAspira FOREIGN KEY (puestoAspira) REFERENCES puestos(nombre),
	CONSTRAINT fk_candidatos_departamento FOREIGN KEY (departamento) REFERENCES departamentos(departamento),
	CONSTRAINT fk_candidatos_competencias FOREIGN KEY (competencias) REFERENCES competencias(descripcion),
	CONSTRAINT fk_candidatos_capacitaciones FOREIGN KEY (capacitaciones) REFERENCES capacitaciones(descripcion),
	CONSTRAINT fk_candidatos_expLaboral FOREIGN KEY (expLaboral) REFERENCES expLaboral(empresa)

);

CREATE TABLE empleados(
	id SERIAL,
	cedula VARCHAR(30),
	nombre VARCHAR(50),
	fechaIngreso DATE,
	departamento VARCHAR(50),
	puesto VARCHAR(50),
	salarioMensual VARCHAR(10),
	estado BOOLEAN,
	CONSTRAINT pk_empleados_id PRIMARY KEY (id),
	CONSTRAINT fk_empleados_cedula FOREIGN KEY (cedula) REFERENCES candidatos(cedula),
	CONSTRAINT uq_empleados_cedula UNIQUE (cedula),
	CONSTRAINT fk_empleados_departamento FOREIGN KEY (departamento) REFERENCES departamentos(departamento),
	CONSTRAINT fk_empleados_puesto FOREIGN KEY (puesto) REFERENCES puestos(nombre)
);


insert into rol(id,descripcion) values(1,'Administrador')
insert into rol(id,descripcion) values(2,'Candidato')

insert into usuarios(id,nombre,correo,clave,idRol) values(1,'Rocio','ro@gmail.com','123',1)
insert into usuarios(id,nombre,correo,clave,idRol) values(2,'Albert','ab@gmail.com','456',2)