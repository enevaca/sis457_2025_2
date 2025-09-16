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
