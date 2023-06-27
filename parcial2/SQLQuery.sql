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


















-- ROLES---
INSERT INTO Roles (rol) VALUES ('admin'), ('cliente');
SELECT *FROM Roles;

--USUARIOS
INSERT INTO Usuarios (nombre, apellido, usuario, correo, contraseña, rolId)
VALUES ('Edwar', 'Gonzalez', 'edwar', 'edwar@correo.com', '123', 1),
       ('Jeisson', 'Paredes', 'je07pe', 'jeisson@correo.com', '123', 2);
SELECT *FROM Usuarios;


