--TABLA CATEGORÍA--

CREATE table Categoria
(
CodigoCategoria INT not null,
NombreCategoria VARCHAR(50),
CONSTRAINT pk_categoria PRIMARY KEY (CodigoCategoria)
);


--TABLA PRODUCTO--

CREATE table Producto
(
CodigoProducto INT not null,
NombreProducto VARCHAR(50),
PrecioUnitario DECIMAL(18,2),
CodigoCategoria INT,
CONSTRAINT pk_producto PRIMARY KEY (CodigoProducto),
CONSTRAINT fk_producto_categoria FOREIGN KEY (CodigoCategoria)
REFERENCES Categoria(CodigoCategoria)
);

--SENTENCIA INSERT--
--|EJEMPLO 1|--

INSERT INTO Categoria VALUES
(1, 'Bebidas');


--|EJEMPLO 2|--

INSERT INTO Categoria (CodigoCategoria,NombreCategoria) VALUES
(2, 'Carnes Rojas');

INSERT INTO Categoria (NombreCategoria,CodigoCategoria) VALUES
('Harinas',3);


--|EJEMPLO 3|--

INSERT INTO Categoria VALUES
(4, 'Vegetales'),
(5, 'Frutas'),
(6, 'Mariscos');


--|EJEMPLO 4|--

INSERT INTO Producto VALUES
(1, 'Soda Coca Cola', 1.25, 1),
(2, 'Carne Bistec', 3.50, 2),
(3, 'Camarones Pequeños', 1.15, 6),
(4, 'Harina Blanca', 0.75, 3),
(5, 'Té Verde', 1.00, 1),
(6, 'Lomo De Aguja', 4.50, 2),
(7, 'Soda De Naranja', 1.25, 1),
(8, 'Chiles Verdes', 0.25, 4),
(9, 'Tomates', 0.2, 4),
(10,'Manzana Verde', 0.25, 5);


--SENTENCIA SELECT-INTO

SELECT * FROM Producto;

SELECT * INTO [Producto_CategoriaBebidas]
FROM Producto
WHERE CodigoCategoria = 1;

SELECT * FROM [Producto CategoriaBebidas];


--SENTENCIA INSERT INTO-SELECT

CREATE TABLE [Producto_CategoriaVegetales]
(
CodigoProducto INT not null,
NombreProducto VARCHAR(50),
PrecioUnitario DECIMAL(18,2),
CodigoCategoria INT
CONSTRAINT pk_producto1 PRIMARY KEY (CodigoProducto)
CONSTRAINT fk_categoria1 FOREIGN KEY (CodigoCategoria)
REFERENCES Categoria(CodigoCategoria)
);

SELECT * FROM [Producto CategoriaVegetales]

INSERT INTO [Producto CategoriaVegetales]
SELECT CodigoProducto,NombreProducto,PrecioUnitario,CodigoCategoria
FROM Producto
WHERE CodigoCategoria =4;


--SENTENCIA UPDATE
--|EJEMPLO 1|--
UPDATE [Producto_CategoriaBebidas] SET PrecioUnitario = 1.50;

SELECT * FROM [Producto_CategoriaBebidas];


--|EJEMPLO 2|--
UPDATE [Producto_CategoriaBebidas] SET PrecioUnitario = 1.25
WHERE CodigoProducto =1;

SELECT * FROM [Producto_CategoriaBebidas];
UPDATE [Producto_CategoriaBebidas] SET PrecioUnitario = 1.75
WHERE CodigoProducto =1 AND CodigoCategoria =1;


--SENTENCIA SELECT
--|EJEMPLO 1|--
DELETE FROM [Producto_CategoriaBebidas];
SELECT * FROM [Producto_CategoriaBebidas];


--|EJEMPLO 2|--
DELETE FROM Producto
WHERE CodigoCategoria =4;
SELECT * FROM Producto


--ON DELETE CASCADE & ON UPDATE CASCADE
--|EJEMPLO 1|--
SELECT * FROM Categoria
DELETE FROM Categoria WHERE CodigoCategoria = 6;

SELECT * FROM Producto

ALTER TABLE Producto
DROP CONSTRAINT fk_categoria

ALTER TABLE Producto
ADD CONSTRAINT fk_categoria
FOREIGN KEY (CodigoCategoria) REFERENCES Categoria (CodigoCategoria)
ON DELETE CASCADE
ON UPDATE CASCADE

DELETE FROM Categoria WHERE CodigoCategoria = 6;

SELECT * FROM Categoria
SELECT * FROM Producto


--|EJEMPLO2|--
CREATE TABLE [Producto_CategoriaFrutas]
(
CodigoProducto INT not null,
NombreProducto VARCHAR(50),
PrecioUnitario DECIMAL(18,2),
CodigoCategoria INT
CONSTRAINT pk_producto2 PRIMARY KEY (CodigoProducto)
CONSTRAINT fk_categoria2 FOREIGN KEY (CodigoCategoria)
REFERENCES Categoria(CodigoCategoria)
ON DELETE CASCADE
ON UPDATE CASCADE
)
