--|EJERCICIO 1|--

CREATE DATABASE ControlAlumno[5136099]
GO

USE ControlAlumno[5136099]
GO

--|EJERCICIO 2|--
--CREAR LA TABLA <ALUMNO>

CREATE TABLE Alumno
(
Carnet char (8) NOT NULL,
NombreCompleto varchar (50) NOT NULL,
--CREANDO LA LLAVE PRIMARIA DE LA TABLA
CONSTRAINT pk_alummno PRIMARY KEY (carnet)
);


--CREAR LA TABLA <MATERIA>

CREATE TABLE Materia
(
Codigo char (5) NOT NULL,
Nombre varchar (30),
UV INT
--CREANDO LA LLAVE PRIMARIA DE LA TABLA
CONSTRAINT pk_materia PRIMARY KEY (Codigo),
--CREANDO UNA RESTRICCIÓN UNIQUE EN EL CAMPO NOMBRE DE LA MATERIA
CONSTRAINT u_nombre UNIQUE (Nombre),
--CREANDO UNA RESTRICCIÓN CHECK EN DONDE LAS UNIDADES VALORATIVAS
--SE ENCUENTRAN ENTRE 2 Y 5 UNIDADES
CONSTRAINT ck_uv CHECK (UV >= 2 AND UV <= 5)
);


--CREAR LA TABLA <INSCRIPCIÓN>

CREATE TABLE Inscripcion
(
Carnet char (8) NOT NULL,
CodigoMateria char (5) NOT NULL,
Ciclo char (5)
--SE ESTÁ CREANDO UNA CLAVE PRIMARIA COMPUESTA
--EN DONDE LA UNIÓN DE LOS TRES DATOS ES UN VALOR ÚNICO
CONSTRAINT pk_inscripcion PRIMARY KEY (Carnet,CodigoMateria,Ciclo)
);

--CREAR LAS RELACIONES ENTRE TABLAS
--INSCRIPCION Y ALUMNO

ALTER TABLE Inscripcion
ADD
--CREANDO LA RELACIÓN ENTRE LA TABLA <INSCRUPCIÓN> Y LA TABLA <ALUMNO>
CONSTRAINT fk_alumno_ins FOREIGN KEY (carnet) REFERENCES Alumno (Carnet)
ON UPDATE CASCADE
ON DELETE CASCADE;


--INSCRIPCION Y MATERIA

ALTER TABLE Inscripcion
ADD
--CREANDO LA RELACIÓN ENTRE LA TABLA <INSCRIPCIÓN> Y LA TABLA <MATERIA>
CONSTRAINT fk_materia_ins FOREIGN KEY (CodigoMateria) REFERENCES Materia (Codigo)
ON UPDATE CASCADE
ON DELETE CASCADE;


--|EJERCICIO 4|--
--AGREGANDO MÚLTIPLES REGISTROS

INSERT INTO Alumno VALUES
('GH121214','gerardo hierro'),
('VN121415','veronica nuñez'),
('CD121515','cesar deras'),
('HL130334','helen lara'),
('GM119056','graciela martinez');

SELECT * FROM Alumno


--AGREGANDO DATOS A LA TABLA <MATERIA>, REGISTRO POR REGISTRO

INSERT INTO Materia VALUES ('BD01', 'Base De Datos I', 4)
INSERT INTO Materia VALUES ('IP01', 'Introduccion A La Programacion', 4)
INSERT INTO Materia VALUES ('AL01', 'Algebra Lineal', 3)
INSERT INTO Materia VALUES ('RD01', 'Redes De Area Amplia', 5)
INSERT INTO Materia VALUES ('GE01', 'Gestion Empresarial', 2)
INSERT INTO Materia VALUES ('HM01', 'Humanistica II', 3)

SELECT * FROM Materia


--AGREGANDO DATOS ESPECIFICANDO EL ORDEN DE LOS CAMPOS DE LA TABLA

INSERT INTO Inscripcion (Carnet,CodigoMateria,Ciclo)
VALUES ('GH121214','BD01','C1-15')

INSERT INTO Inscripcion (CodigoMateria,Carnet,Ciclo)
VALUES ('GE01','GH121214','C1-15')

INSERT INTO Inscripcion (Ciclo,Carnet,CodigoMateria)
VALUES ('C1-15','GH121214','HM01')

SELECT * FROM Inscripcion


--|EJERCICIO 5|--

UPDATE Alumno SET NombreCompleto = 'Gerardo Hernandez'
WHERE Carnet = 'GH111214'

SELECT * FROM Alumno
SELECT * FROM Inscripcion

UPDATE Alumno SET Carnet ='GH111214'
WHERE NombreCompleto = 'Gerardo Hernandez'


--|EJERCICIO 6|--

DELETE FROM Alumno 
WHERE Carnet = 'GM119056'

SELECT * FROM Alumno
SELECT * FROM Inscripcion


--|EJERCICIOS COMPLEMENTARIOS|--
--|EJERCICIO A|--

INSERT INTO Alumno VALUES
('MC129854','Mauricio Campos'),
('IP110943','Ignacio Perez'),
('MU127895','Mikel Urrutia'),
('CH132390','Carlos Hernandez'),
('HL139032','Herson Lopez');


--|EJERCICIO B|--

INSERT INTO Inscripcion (Carnet,CodigoMateria,Ciclo)
VALUES ('CD121515','AL01','C1-14')

INSERT INTO Inscripcion (Carnet,CodigoMateria,Ciclo)
VALUES ('CD121515','GE01','C1-14')

INSERT INTO Inscripcion (Carnet,CodigoMateria,Ciclo)
VALUES ('CD121515','HM01','C1-15')

INSERT INTO Inscripcion (Carnet,CodigoMateria,Ciclo)
VALUES ('GM119056','IP01','C1-14')

INSERT INTO Inscripcion (Carnet,CodigoMateria,Ciclo)
VALUES ('GM119056','RD02','C1-14')

INSERT INTO Inscripcion (Carnet,CodigoMateria,Ciclo)
VALUES ('HL130334','BD01','C1-15')

INSERT INTO Inscripcion (Carnet,CodigoMateria,Ciclo)
VALUES ('VN121415','BD01','C1-15')

INSERT INTO Inscripcion (Carnet,CodigoMateria,Ciclo)
VALUES ('VN121415','RD02','C1-15')

INSERT INTO Inscripcion (Carnet,CodigoMateria,Ciclo)
VALUES ('MC129854','AL01','C1-14')

INSERT INTO Inscripcion (Carnet,CodigoMateria,Ciclo)
VALUES ('MC129854','GE01','C1-14')

INSERT INTO Inscripcion (Carnet,CodigoMateria,Ciclo)
VALUES ('IP110943','GE01','C1-15')

INSERT INTO Inscripcion (Carnet,CodigoMateria,Ciclo)
VALUES ('IP110943','HM02','C1-15')

SELECT * FROM Inscripcion


--|EJERCICIO C|--

SELECT * INTO MateriaUV 
FROM Materia 
WHERE UV >= 4;

SELECT * FROM MateriaUV

--|EJERCICIO D|--

SELECT * INTO Alumno2012
FROM Alumno
WHERE Carnet = '2012';

INSERT INTO Alumno2012 VALUES
('2011','gerardo hernandez'),
('2013','veronica nuñez'),
('2012','cesar deras'),
('2000','helen lara'),
('2035','gricelda martinez');

SELECT * FROM Alumno2012
WHERE Carnet = '2012';


--|EJERCICIO E|--
--CONSULA 1--

UPDATE Alumno SET NombreCompleto = 'Gricelda Marquez'
WHERE Carnet = 'GM119056'

SELECT * FROM Alumno


--CONSULTA 2--

INSERT INTO Alumno VALUES
('GM119058','Gricelda Marquez');

UPDATE Alumno SET Carnet = 'GM119156'

SELECT * FROM Alumno


--CONSULTA 3--

UPDATE Inscripcion SET Ciclo ='C2-15'

SELECT * FROM Inscripcion


--CONSULTA 4--

UPDATE Materia SET Codigo ='HM02'
WHERE Nombre = 'Humanistica II'

UPDATE Materia SET Codigo ='HM01'
WHERE Codigo = 'HM02'

SELECT * FROM Materia


--CONSULTA 5--

UPDATE ALumno SET NombreCompleto = 'Ignacio Pereira'
WHERE Carnet = 'IP110943'

SELECT * FROM Alumno


--|EJERCICIO F|--
--CONSULTA 1--

DELETE FROM Alumno
WHERE Carnet = 'IP110943';

SELECT * FROM Alumno


--CONSULTA 2--

DELETE FROM Alumno
WHERE Carnet LIKE 'M%';

SELECT * FROM Alumno


--CONSULTA 3--

DELETE FROM Materia
WHERE Nombre = 'Introduccion A La programacion'

SELECT * FROM Materia


--CONSULTA 4--

INSERT INTO Alumno VALUES
('OH129854','Oscar Hernandez')

DELETE FROM Alumno
WHERE NombreCompleto = 'Oscar Hernandez'

SELECT * FROM Alumno


--CONSULTA 5--

DELETE FROM Inscripcion
WHERE CodigoMateria = 'RD02' AND Ciclo = 'C1-15'

SELECT * FROM Inscripcion