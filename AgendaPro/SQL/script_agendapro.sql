CREATE DATABASE AgendaPro;
GO

USE AgendaPro;
GO

CREATE TABLE Rol(
    IdRol INT PRIMARY KEY IDENTITY(1,1),
    NombreRol VARCHAR(50) NOT NULL
);

CREATE TABLE Usuario(
    IdUsuario INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(100) NOT NULL,
    Correo VARCHAR(100) UNIQUE NOT NULL,
    Contraseña VARCHAR(100) NOT NULL,
    IdRol INT NOT NULL,
    FOREIGN KEY(IdRol) REFERENCES Rol(IdRol)
);

CREATE TABLE Cliente(
    IdCliente INT PRIMARY KEY IDENTITY(1,1),
    Documento VARCHAR(20) UNIQUE NOT NULL,
    Nombre VARCHAR(100) NOT NULL,
    Telefono VARCHAR(20),
    Correo VARCHAR(100)
);

CREATE TABLE Profesional(
    IdProfesional INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(100) NOT NULL,
    Especialidad VARCHAR(100),
    Estado VARCHAR(20) DEFAULT 'Activo'
);

CREATE TABLE Servicio(
    IdServicio INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(100) NOT NULL,
    DuracionMinutos INT NOT NULL,
    Precio DECIMAL(10,2)
);

CREATE TABLE Cita(
    IdCita INT PRIMARY KEY IDENTITY(1,1),
    Fecha DATE NOT NULL,
    HoraInicio TIME NOT NULL,
    HoraFin TIME NOT NULL,
    Estado VARCHAR(30) DEFAULT 'Pendiente',

    IdCliente INT NOT NULL,
    IdProfesional INT NOT NULL,
    IdServicio INT NOT NULL,

    FOREIGN KEY(IdCliente) REFERENCES Cliente(IdCliente),
    FOREIGN KEY(IdProfesional) REFERENCES Profesional(IdProfesional),
    FOREIGN KEY(IdServicio) REFERENCES Servicio(IdServicio)
);

INSERT INTO Rol VALUES
('Administrador'),
('Recepcionista'),
('Profesional');

INSERT INTO Servicio VALUES
('Consulta Técnica',60,80000),
('Mantenimiento',120,150000),
('Asesoría',45,60000);