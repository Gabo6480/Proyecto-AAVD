--CREATE KEYSPACE "Proyecto_AAVD"
--WITH replication ={'class':'SimpleStrategy','replication_factor':1};

DROP TABLE IF EXISTS pais;
CREATE TABLE IF NOT EXISTS pais(
	id		UUID	PRIMARY KEY,
	nombre	TEXT
);
INSERT INTO pais(id,nombre) VALUES(UUID(),'México');
INSERT INTO pais(id,nombre) VALUES(UUID(),'Estados Unidos');
INSERT INTO pais(id,nombre) VALUES(UUID(),'Canadá');
INSERT INTO pais(id,nombre) VALUES(UUID(),'Japón');

DROP TABLE IF EXISTS semestre;
CREATE TABLE IF NOT EXISTS semestre(
	id				UUID,
	nombre			TEXT,
	fecha_inicio	DATE,
	fecha_fin		DATE,
	creditos_min	SMALLINT,
	creditos_max	SMALLINT,
	estado			TEXT,
	PRIMARY KEY(id,fecha_inicio,estado)
);
--select * from semestre;

DROP TABLE IF EXISTS maestro;	
DROP TABLE IF EXISTS carrera;
DROP TYPE IF EXISTS rmateria;

CREATE TYPE IF NOT EXISTS rmateria(
	clave INT,
	nombre TEXT,
	alias TEXT
);

CREATE TABLE IF NOT EXISTS carrera(
	id				UUID,
	clave			INT,
	nombre			TEXT,
	alias			TEXT,
	descripcion		TEXT,
	materias		SET<FROZEN<rmateria>>,
	PRIMARY KEY(id)
);
--INSERT INTO carrera(id,clave,nombre,alias,descripcion) values (UUID(),123,'Prueba','Prba','None');
--Select * from carrera;
SELECT materias FROM carrera WHERE id =934f898c-80dc-4906-8768-5e1bc8b06b64;
--UPDATE carrera SET materias = materias - {{clave : 22,nombre : 'Otra',alias : 'OT'}} WHERE id = 934f898c-80dc-4906-8768-5e1bc8b06b64;

CREATE TABLE IF NOT EXISTS maestro(
	matricula		INT				PRIMARY KEY,
	num_nomina		TEXT,
	nombre			TEXT,
	apellido_pat	TEXT,
	apellido_mat	TEXT,
	genero			BOOLEAN,
	fecha_naci		DATE,
	titulo			TEXT,
	materias		SET<FROZEN<rmateria>>,
	nombre_completo TEXT
);
select * from maestro;

DROP TABLE IF EXISTS coordinador;
CREATE TABLE IF NOT EXISTS coordinador(
	clave_usuario	TEXT,
	contrasena		TEXT,
	
	num_nomina		TEXT,
	nombre			TEXT,
	apellido_pat	TEXT,
	apellido_mat	TEXT,
	titulo			TEXT,
	genero			BOOLEAN,
	fecha_naci		DATE,

	carrera		TEXT,
	PRIMARY KEY(clave_usuario,contrasena)
);
INSERT INTO coordinador (clave_usuario,contrasena,num_nomina,nombre,apellido_pat,apellido_mat,titulo,genero,fecha_naci,carrera) 
			VALUES ('Admin123','1887916','0000','Gabriel','Aguirre','González','Administrador/a',true,'1999-01-24','null');
select * from coordinador;
			
DROP TABLE IF EXISTS materia;		
CREATE TABLE IF NOT EXISTS materia(
	id					UUID,
	clave				INT,
	nombre				TEXT,
	alias				TEXT,
	descripcion			TEXT,
	creditos			SMALLINT,
	medias_horas_sem	SMALLINT,
	nivel				TINYINT,
	PRIMARY KEY(id,clave)
);
--select * from materia;

DROP TABLE IF EXISTS alumno;		
CREATE TABLE IF NOT EXISTS alumno(
	matricula		INT,
	nombre			TEXT,
	apellido_pat	TEXT,
	apellido_mat	TEXT,
	genero			BOOLEAN,
	fecha_naci		DATE,
	activo			BOOLEAN,

	carrera			TEXT,
	pais			TEXT,
	PRIMARY KEY(matricula,carrera,activo)
);

DROP TABLE IF EXISTS grupo;
DROP TYPE IF EXISTS horario;
DROP TYPE IF EXISTS grupo_alumno;

CREATE TYPE IF NOT EXISTS horario(
hora		TIME	,
lunes		BOOLEAN,
martes		BOOLEAN,
miercoles	BOOLEAN,
jueves		BOOLEAN,
viernes		BOOLEAN,
sabado		BOOLEAN
);
CREATE TYPE IF NOT EXISTS grupo_alumno(
	matricula INT,
	nombre TEXT,
	calificacion FLOAT
);
CREATE TABLE IF NOT EXISTS grupo(
	id			UUID,
	horario 	SET<FROZEN<horario>>,
	alumnos		SET<FROZEN<grupo_alumno>>,
	cupo		INT,
	
	materia		TEXT,
	maestro		TEXT,
	aula		TEXT,
	semestre	TEXT,
	PRIMARY KEY(id)		
);

DROP TABLE IF EXISTS kardex;
CREATE TABLE IF NOT EXISTS kardex(
	nombre TEXT,
	materia TEXT,
	grupo	UUID,
	matricula INT,
	calificacion FLOAT,
	semestre	TEXT,
	PRIMARY KEY(matricula,grupo,semestre)
);

/*CREATE TABLE "HORARIO"(
id			INT		PRIMARY KEY IDENTITY(0,1),
hora		TIME	,
lunes		BOOLEAN		DEFAULT(0),
martes		BOOLEAN		DEFAULT(0),
miercoles	BOOLEAN		DEFAULT(0),
jueves		BOOLEAN		DEFAULT(0),
viernes		BOOLEAN		DEFAULT(0),
sabado		BOOLEAN		DEFAULT(0)
)--Entidad Debil para GRUPO*/

/*CREATE TABLE AULA(
id				INT				PRIMARY KEY IDENTITY(0,1),
cupo			INT				,
localizacion	VARCHAR(255)	
)--Entidad Debil para GRUPO
INSERT INTO AULA(cupo,localizacion) VALUES(10,'Ejemplo');*/

/*--Tablas Relacionales
CREATE TABLE MATERIA_CARRERA(
id			INT		PRIMARY KEY IDENTITY(0,1),
carrera_fk		INT				,
materia_fk		INT				,
CONSTRAINT FK_CARRERA_ESTUDIA FOREIGN KEY(carrera_fk) REFERENCES CARRERA(clave),
CONSTRAINT FK_MATERIA_ESTUDIADA FOREIGN KEY(materia_fk) REFERENCES MATERIA(clave)
)

CREATE TABLE BLOQUEO_MATERIA(
id				INT		PRIMARY KEY IDENTITY(0,1),
bloque_fk		INT				,
materia_fk		INT				,
CONSTRAINT FK_MATERIA_BLOQUEADORA FOREIGN KEY(bloque_fk) REFERENCES MATERIA(clave),
CONSTRAINT FK_MATERIA_BLOQUEADA FOREIGN KEY(materia_fk) REFERENCES MATERIA(clave)
)

CREATE TABLE MAESTRO_MATERIA(
id				INT		PRIMARY KEY IDENTITY(0,1),
maestro_fk		INT				,
materia_fk		INT				,
CONSTRAINT FK_MAESTRO_ENSEÃ‘ANTE FOREIGN KEY(maestro_fk) REFERENCES MAESTRO(matricula),
CONSTRAINT FK_MATERIA_ENSEÃ‘ADA FOREIGN KEY(materia_fk) REFERENCES MATERIA(clave)
)

CREATE TABLE HORARIO_GRUPO(
id					INT		PRIMARY KEY IDENTITY(0,1),
grupo_fk			INT				,
horario_fk			INT				,
CONSTRAINT FK_GRUPO FOREIGN KEY(grupo_fk) REFERENCES GRUPO(id),
CONSTRAINT FK_HORARIO FOREIGN KEY(horario_fk) REFERENCES HORARIO(id)
)

CREATE TABLE ALUMNO_GRUPO(
id					INT		PRIMARY KEY IDENTITY(0,1),
calificacion		FLOAT			,
fecha_calif			DATE			,
grupo_fk			INT				,
alumno_fk			INT				,
CONSTRAINT FK_GRUPO_INSCRITO FOREIGN KEY(grupo_fk) REFERENCES GRUPO(id),
CONSTRAINT FK_ALUMNO_INSCRITO FOREIGN KEY(alumno_fk) REFERENCES ALUMNO(matricula)
)*/