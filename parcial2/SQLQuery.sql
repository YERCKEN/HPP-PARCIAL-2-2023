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

select *from usuarios;


-- Crear la tabla "Tickets"
CREATE TABLE Tickets (
  idTiket INT IDENTITY(1,1) PRIMARY KEY,
  idUsuario INT FOREIGN KEY REFERENCES Usuarios(id),
  estado VARCHAR(255),
  tipoSoporte VARCHAR(255),
  equipo VARCHAR(255),
  costoInicial DECIMAL(10, 2),
  costoFinal DECIMAL(10, 2),
  fechaInicio DATE,
  fechaFinalizacion DATE,
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



	-- Crear el procedimiento almacenado OBTENER TIKET POR USUARIO ID =====================================
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



 --PROCEDIMIENTO PARA SELECCIONAR TODOS LOS TIKETS
CREATE PROCEDURE ObtenerTodosLosTickets
AS
BEGIN
  SELECT
    T.idTiket,
	U.id AS idUsuario,
    U.usuario,
    T.estado,
    T.tipoSoporte,
    T.equipo,
    T.costoInicial,
    T.costoFinal,
    T.fechaInicio,
    T.fechaFinalizacion,
    T.observacion
  FROM Tickets T
  INNER JOIN Usuarios U ON T.idUsuario = U.id;
END
EXEC ObtenerTodosLosTickets;

 --PROCEDIMIENTO PARA SELECCIONAR TODOS LOS TIKETS en espera

CREATE PROCEDURE ObtenerTicketsConUsuariosEnEspera
AS
BEGIN
  SELECT
    T.idTiket,
    U.usuario,
    U.id AS idUsuario,
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
  WHERE T.estado = 'En espera';
END

EXEC ObtenerTicketsConUsuariosEnEspera;

 --PROCEDIMIENTO PARA SELECCIONAR TODOS LOS TIKETS en PROCESO

CREATE PROCEDURE ObtenerTicketsConUsuariosEnProceso
AS
BEGIN
  SELECT
    T.idTiket,
    U.usuario,
    U.id AS idUsuario,
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
  WHERE T.estado = 'En proceso';
END

EXEC ObtenerTicketsConUsuariosEnProceso;


 --PROCEDIMIENTO PARA SELECCIONAR TODOS LOS TIKETS en PROCESO

CREATE PROCEDURE ObtenerTicketsConUsuariosTerminado
AS
BEGIN
  SELECT
    T.idTiket,
    U.usuario,
    U.id AS idUsuario,
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
  WHERE T.estado = 'Terminado';
END

EXEC ObtenerTicketsConUsuariosTerminado;




--verificar si existe el ID y hacer ele select
CREATE PROCEDURE VerificarTicket
  @idTiket INT
AS
BEGIN
  -- Verificar si el ID de ticket existe
  IF EXISTS (SELECT 1 FROM Tickets WHERE idTiket = @idTiket)
  BEGIN
    -- Realizar la consulta y mostrar los resultados
    SELECT t.*, u.usuario, u.id AS idUsuario
    FROM Tickets t
    INNER JOIN Usuarios u ON t.idUsuario = u.id
    WHERE t.idTiket = @idTiket;
  END
END;

EXEC VerificarTicket @idTiket = 1;



--actualizar tikets 

CREATE PROCEDURE ActualizarTicket
  @idTicket INT,
  @idUsuario INT,
  @estado VARCHAR(255),
  @tipoSoporte VARCHAR(255),
  @equipo VARCHAR(255),
  @costoInicial DECIMAL(10, 2),
  @costoFinal DECIMAL(10, 2),
  @fechaInicio DATE,
  @fechaFinalizacion DATE,
  @observacion VARCHAR(255)
AS
BEGIN
  UPDATE Tickets
  SET idUsuario = @idUsuario,
      estado = @estado,
      tipoSoporte = @tipoSoporte,
      equipo = @equipo,
      costoInicial = @costoInicial,
      costoFinal = @costoFinal,
      fechaInicio = @fechaInicio,
      fechaFinalizacion = @fechaFinalizacion,
      observacion = @observacion
  WHERE idTiket = @idTicket;
END;





-- ROLES---
INSERT INTO Roles (rol) VALUES ('admin'), ('cliente');
SELECT *FROM Roles;

--USUARIOS
INSERT INTO Usuarios (nombre, apellido, usuario, correo, contraseña, rolId)
VALUES ('Edwar', 'Gonzalez', 'edwar', 'edwar@correo.com', '123', 1),
       ('Jeisson', 'Paredes', 'je07pe', 'jeisson@correo.com', '123', 2);
SELECT *FROM Usuarios;



select *from Tickets;
--tikets 

INSERT INTO Tickets (idUsuario, estado, tipoSoporte, equipo, costoInicial, fechaInicio, fechaFinalizacion, costoFinal )
VALUES --(5, 'En proceso', 'Correctivo', 'Equipo XYZ', 100.00, '2023-6-28', '2023-7-4'),
	   (5, 'En proceso', 'Correctivo', 'Equipo XYZ', 20.00, '2023-6-28', '2023-7-20', 30.00),
	   (5, 'En proceso', 'Correctivo', 'DELL', 20.00, '2023-6-28', '2023-7-10', 45.00);