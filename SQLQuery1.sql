CREATE DATABASE Carnicería;

USE Carnicería;

-- Pedidos
CREATE TABLE PEDIDOS (
    ID INT PRIMARY KEY IDENTITY(1,1),
    FechaDeEntrega DATE,
    FechaDePago DATE,
    ModoDePago NVARCHAR(50)
);

ALTER TABLE PEDIDOS
ADD Proveedor NVARCHAR(100);

INSERT INTO PEDIDOS (FechaDeEntrega, FechaDePago, ModoDePago, Proveedor)
VALUES ('2024-08-08', '2024-08-07', 'Tarjeta de Crédito', 'Proveedor A');

INSERT INTO PEDIDOS (FechaDeEntrega, FechaDePago, ModoDePago, Proveedor)
VALUES ('2024-08-10', '2024-08-09', 'Efectivo', 'Proveedor B');

ALTER TABLE PEDIDOS
ALTER COLUMN FechaDeEntrega DATE;

SELECT * FROM PEDIDOS;


CREATE TABLE STOCK (
	ID INT PRIMARY KEY IDENTITY(1,1),
	Productos NVARCHAR(1000),
	Cantidad NVARCHAR(1000)
	);

	INSERT INTO STOCK (Productos, Cantidad)
	VALUES ('Lechona', '300');

	SELECT * FROM STOCK;


CREATE TABLE PRODUCTOS (
	Productos NVARCHAR(1000),
	Precio NVARCHAR(1000)
	);

	INSERT INTO PRODUCTOS (Productos, Precio)
	VALUES ('Mondongo', '4000');

	SELECT * FROM PRODUCTOS;

CREATE TABLE CLIENTES (
    ID INT PRIMARY KEY IDENTITY(1,1),    
    Telefono NVARCHAR(50),               
    Nombre NVARCHAR(100),                
    Apellido NVARCHAR(100)               
);

CREATE TABLE PROVEEDORES (
	ID INT PRIMARY KEY IDENTITY(1,1),  
	Telefono NVARCHAR(50),               
    Nombre NVARCHAR(100),                
    Apellido NVARCHAR(100),
	Producto NVARCHAR(1000)
	);

	
INSERT INTO CLIENTES(Telefono, Nombre, Apellido)
VALUES ('3482 567890', 'Mario', 'Montiel');

INSERT INTO PROVEEDORES (Telefono, Nombre, Apellido, Producto)
VALUES ('3482 567890', 'Maria', 'Montiela', 'Mondongo');

SELECT * FROM CLIENTES;
SELECT * FROM PROVEEDORES;
SELECT * FROM STOCK;
SELECT * FROM PRODUCTOS;
SELECT * FROM PEDIDOS;



