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
  contrase�a VARCHAR(255),
  rolId INT FOREIGN KEY REFERENCES Roles(id)
);

--PROCEDIMIENTO ALMACENADO PARA LOGIN

CREATE PROCEDURE VerificarLogin
  @usuario VARCHAR(255),
  @contrase�a VARCHAR(255)
AS
BEGIN
  SET NOCOUNT ON;
  
  -- Variable para almacenar el resultado de la verificaci�n
  DECLARE @Resultado INT;
  
  -- Verificar el inicio de sesi�n
  SELECT @Resultado = COUNT(*)
  FROM Usuarios
  WHERE usuario = @usuario AND contrase�a = @contrase�a;
  
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
  @contrase�a VARCHAR(255),
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
  INSERT INTO Usuarios (nombre, apellido, usuario, correo, contrase�a, rolId)
  VALUES (@nombre, @apellido, @usuario, @correo, @contrase�a, @rolId);

  -- Retornar un valor indicando el �xito de la inserci�n
  SELECT 1 AS Resultado
END;


EXEC InsertarUsuario 'John', 'Doe', 'JONH 1', 'johndoe@example.com', 'contrase�a123', 1;


















-- ROLES---
INSERT INTO Roles (rol) VALUES ('admin'), ('cliente');
SELECT *FROM Roles;

--USUARIOS
INSERT INTO Usuarios (nombre, apellido, usuario, correo, contrase�a, rolId)
VALUES ('Edwar', 'Gonzalez', 'edwar', 'edwar@correo.com', '123', 1),
       ('Jeisson', 'Paredes', 'je07pe', 'jeisson@correo.com', '123', 2);
SELECT *FROM Usuarios;


