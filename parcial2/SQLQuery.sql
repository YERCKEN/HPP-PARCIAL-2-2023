CREATE DATABASE parcial2Hpp;
USE parcial2Hpp;


-- Crear la tabla "Roles"
CREATE TABLE Roles (
  id INT IDENTITY(1,1) PRIMARY KEY,
  rol VARCHAR(255)
);


-- Crear la tabla "Usuarios"
CREATE TABLE Usuarios (
  id INT IDENTITY(1,1) PRIMARY KEY,
  nombre VARCHAR(255),
  apellido VARCHAR(255),
  usuario VARCHAR(255) UNIQUE,
  correo VARCHAR(255),
  contraseña VARCHAR(255),
  rolId INT FOREIGN KEY REFERENCES Roles(id)
);

-- Crear la tabla "Tickets"
CREATE TABLE Tickets (
  idTiket INT IDENTITY(1,1) PRIMARY KEY,
  idUsuario INT FOREIGN KEY REFERENCES Usuarios(id),
  estado VARCHAR(255),
  tipoSoporte VARCHAR(255),
  equipo VARCHAR(255),
  costoInicial DECIMAL(10, 2),
  costoFinal DECIMAL(10, 2),
  fechaInicio DATETIME,
  fechaFinalizacion DATETIME,
  observacion VARCHAR(255)
);


--PROCEDIMIENTO ALMACENADO PARA LOGIN

CREATE PROCEDURE VerificarLogin
  @usuario VARCHAR(255),
  @contraseña VARCHAR(255)
AS
BEGIN
  SET NOCOUNT ON;
  
  -- Variable para almacenar el resultado de la verificación
  DECLARE @Resultado INT;
  
  -- Verificar el inicio de sesión
  SELECT @Resultado = COUNT(*)
  FROM Usuarios
  WHERE usuario = @usuario AND contraseña = @contraseña;
  
  -- Devolver el resultado
  SELECT @Resultado AS 'Resultado';
END;

--VERIFICO
EXEC VerificarLogin 'edwar', '123';



--PROCEDIMIENTO USUARIO ===========================================================================================

CREATE PROCEDURE InsertarUsuario
  @nombre VARCHAR(255),
  @apellido VARCHAR(255),
  @usuario VARCHAR(255),
  @correo VARCHAR(255),
  @contraseña VARCHAR(255),
  @rolId INT
AS
BEGIN
  SET NOCOUNT ON;

  -- Verificar si el usuario ya existe
  IF EXISTS (SELECT 1 FROM Usuarios WHERE usuario = @usuario)
  BEGIN
    -- El usuario ya existe, retornar un valor indicando el error
    SELECT 0 AS Resultado
    RETURN
  END

  -- Insertar el nuevo usuario
  INSERT INTO Usuarios (nombre, apellido, usuario, correo, contraseña, rolId)
  VALUES (@nombre, @apellido, @usuario, @correo, @contraseña, @rolId);

  -- Retornar un valor indicando el éxito de la inserción
  SELECT 1 AS Resultado
END;


EXEC InsertarUsuario 'John', 'Doe', 'JONH 1', 'johndoe@example.com', 'contraseña123', 1;


--PROCEDIMIENTO SELECT DE DATOS==========================================================================================

CREATE PROCEDURE ObtenerUsuariosConRoles
    @usuario VARCHAR(255)
AS
BEGIN
    SELECT
        U.id AS UsuarioID,
        U.nombre AS Nombre,
        U.apellido AS Apellido,
        U.usuario AS Usuario,
        U.correo AS Correo,
        R.rol AS Rol
    FROM
        Usuarios U
        INNER JOIN Roles R ON U.rolId = R.id
    WHERE
        U.usuario = @usuario;
END

EXEC ObtenerUsuariosConRoles @usuario = 'je07pe';





--procedimiento insert nuevo tiket 
--procedimiento insert nuevo tiket 
CREATE PROCEDURE InsertarTicket
    @idUsuario INT,
    @observacion VARCHAR(255),
    @tipoSoporte VARCHAR(255),
    @equipo VARCHAR(255)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Tickets (idUsuario, observacion, tipoSoporte, equipo, estado)
    VALUES (@idUsuario, @observacion, @tipoSoporte, @equipo, 'En espera');
END


EXEC InsertarTicket
    @idUsuario = 2,
    @observacion = 'Sistema',
    @tipoSoporte = 'Preventivo',
    @equipo = 'Gygabyte G5'



	-- Crear el procedimiento almacenado
CREATE PROCEDURE ObtenerTicketsPorUsuario
  @idUsuario INT
AS
BEGIN
  SELECT T.idTiket,
         U.nombre AS nombreUsuario,
         T.estado,
         T.tipoSoporte,
         T.equipo,
         T.costoInicial,
         T.costoFinal,
         T.fechaInicio,
         T.fechaFinalizacion,
         T.observacion
  FROM Tickets T
  INNER JOIN Usuarios U ON T.idUsuario = U.id
  WHERE T.idUsuario = @idUsuario;
END;

 EXEC ObtenerTicketsPorUsuario @idUsuario = 2;






-- ROLES---
INSERT INTO Roles (rol) VALUES ('admin'), ('cliente');
SELECT *FROM Roles;

--USUARIOS
INSERT INTO Usuarios (nombre, apellido, usuario, correo, contraseña, rolId)
VALUES ('Edwar', 'Gonzalez', 'edwar', 'edwar@correo.com', '123', 1),
       ('Jeisson', 'Paredes', 'je07pe', 'jeisson@correo.com', '123', 2);
SELECT *FROM Usuarios;



select *from Tickets
--tikets 

INSERT INTO Tickets (idUsuario, estado, tipoSoporte, equipo, costoInicial, costoFinal)
VALUES (2, 'Activo', 'Soporte Técnico', 'Equipo XYZ', 100.00, 150.00);