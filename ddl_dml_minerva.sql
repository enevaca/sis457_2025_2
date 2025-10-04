CREATE DATABASE Minerva;
USE master
GO
CREATE LOGIN usrminerva WITH PASSWORD = '123456',
	CHECK_POLICY = ON,
	CHECK_EXPIRATION = OFF,
	DEFAULT_DATABASE = Minerva
GO
USE Minerva
GO
CREATE USER usrminerva FOR LOGIN usrminerva
GO
ALTER ROLE db_owner ADD MEMBER usrminerva
GO

DROP TABLE IF EXISTS CompraDetalle;
DROP TABLE IF EXISTS Compra;
DROP TABLE IF EXISTS Usuario;
DROP TABLE IF EXISTS Empleado;
DROP TABLE IF EXISTS Proveedor;
DROP TABLE IF EXISTS Producto;
DROP TABLE IF EXISTS UnidadMedida;

CREATE TABLE UnidadMedida (
  id INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
  descripcion VARCHAR(20) NOT NULL UNIQUE
);
CREATE TABLE Producto (
  id INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
  idUnidadMedida INT NOT NULL,
  codigo VARCHAR(20) NOT NULL,
  descripcion VARCHAR(200) NOT NULL,
  saldo DECIMAL NOT NULL DEFAULT 0,
  precioVenta DECIMAL NOT NULL CHECK (precioVenta > 0),
  CONSTRAINT fk_Producto_UnidadMedida FOREIGN KEY (idUnidadMedida) REFERENCES UnidadMedida(id)
);
CREATE TABLE Proveedor (
  id INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
  nit BIGINT NOT NULL,
  razonSocial VARCHAR(100) NOT NULL UNIQUE,
  direccion VARCHAR(250) NULL,
  celular BIGINT NOT NULL,
  representante VARCHAR(100) NOT NULL
);
CREATE TABLE Empleado (
  id INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
  cedulaIdentidad VARCHAR(12) NOT NULL UNIQUE,
  nombres VARCHAR(50) NOT NULL,
  primerApellido VARCHAR(50) NULL,
  segundoApellido VARCHAR(50) NULL,
  fechaNacimiento DATE NOT NULL,
  direccion VARCHAR(250) NOT NULL,
  celular BIGINT NOT NULL,
  cargo VARCHAR(50) NOT NULL
);
CREATE TABLE Usuario (
  id INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
  idEmpleado INT NOT NULL,
  usuario VARCHAR(15) NOT NULL UNIQUE,
  clave VARCHAR(250) NOT NULL,
  CONSTRAINT fk_Usuario_Empleado FOREIGN KEY (idEmpleado) REFERENCES Empleado(id)
);
CREATE TABLE Compra (
  id BIGINT NOT NULL PRIMARY KEY IDENTITY(1, 1),
  idProveedor INT NOT NULL,
  transaccion INT NOT NULL,
  fecha DATE NOT NULL DEFAULT GETDATE(),
  total DECIMAL NOT NULL CHECK (total > 0),
  CONSTRAINT fk_Compra_Proveedor FOREIGN KEY (idProveedor) REFERENCES Proveedor(id)
);
CREATE TABLE CompraDetalle (
  id BIGINT NOT NULL PRIMARY KEY IDENTITY(1, 1),
  idCompra BIGINT NOT NULL,
  idProducto INT NOT NULL,
  cantidad DECIMAL NOT NULL CHECK (cantidad > 0),
  precioUnitario DECIMAL NOT NULL CHECK (precioUnitario > 0),
  total DECIMAL NOT NULL CHECK (total > 0),
  CONSTRAINT fk_CompraDetalle_Compra FOREIGN KEY (idCompra) REFERENCES Compra(id),
  CONSTRAINT fk_CompraDetalle_Producto FOREIGN KEY (idProducto) REFERENCES Producto(id)
);

ALTER TABLE UnidadMedida ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE UnidadMedida ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE UnidadMedida ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

ALTER TABLE Producto ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Producto ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Producto ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

ALTER TABLE Proveedor ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Proveedor ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Proveedor ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

ALTER TABLE Empleado ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Empleado ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Empleado ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

ALTER TABLE Usuario ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Usuario ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Usuario ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

ALTER TABLE Compra ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Compra ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Compra ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

ALTER TABLE CompraDetalle ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE CompraDetalle ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE CompraDetalle ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

GO
DROP PROC IF EXISTS paProductoListar;
GO
CREATE PROC paProductoListar @parametro VARCHAR(50)
AS
  SELECT p.id, p.idUnidadMedida,p.codigo,p.descripcion,um.descripcion AS unidadMedida,
		 p.saldo,p.precioVenta,p.usuarioRegistro,p.fechaRegistro,p.estado
  FROM Producto p
  INNER JOIN UnidadMedida um ON um.id = p.idUnidadMedida
  WHERE p.estado>-1 AND p.codigo+p.descripcion+um.descripcion LIKE '%'+REPLACE(@parametro,' ','%')+'%'
  ORDER BY p.estado DESC, p.descripcion ASC;

EXEC paProductoListar 'bond carta';

-- DML
INSERT INTO UnidadMedida(descripcion)
VALUES ('Caja'), ('Docena'), ('Metro'), ('Paquete'), ('Pliego'),('Unidad');

--SELECT * FROM UnidadMedida;

INSERT INTO Producto(codigo,descripcion,idUnidadMedida,saldo,precioVenta)
VALUES ('BL006', 'Bolígrafo Pilot Color Azul',1,0,22);

INSERT INTO Producto(codigo,descripcion,idUnidadMedida,saldo,precioVenta)
VALUES ('PB005', 'Papel Bond Tamaño Carta',4,0,42);

INSERT INTO Producto(codigo,descripcion,idUnidadMedida,saldo,precioVenta)
VALUES ('PB004', 'Papel Bond Tamaño Oficio',4,0,48);

