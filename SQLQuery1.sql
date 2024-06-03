CREATE DATABASE SucursalesDB;
GO

USE SucursalesDB;
GO

CREATE TABLE Sucursales(
    SucursalID INT PRIMARY KEY IDENTITY,
    Nombre NVARCHAR(100),
    Direccion NVARCHAR(200),
    Ciudad NVARCHAR(100),
    Provincia NVARCHAR(100),
    CodigoPostal NVARCHAR(20),
    Telefono NVARCHAR(20),
    Email NVARCHAR(100),
    FechaApertura DATE,
    Gerente NVARCHAR(100),
);
select * from Sucursales
