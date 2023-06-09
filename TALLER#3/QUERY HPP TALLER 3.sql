
CREATE DATABASE bdHppTaller3;
USE bdHppTaller3;


-- INICIO QUERYS
CREATE TABLE Authors (
Id INT NOT NULL IDENTITY,
Name VARCHAR(70) NOT NULL,
Country VARCHAR(100) NOT NULL,
PRIMARY KEY(Id)
);

CREATE TABLE Books (
Id INT NOT NULL IDENTITY,
Title VARCHAR(50) NOT NULL,
PRIMARY KEY(Id))
;


CREATE TABLE BooksAuthors (
AuthorId INT NOT NULL,
BookId  INT NOT NULL,
FOREIGN KEY (AuthorId) REFERENCES Authors(Id),
FOREIGN KEY (BookId) REFERENCES Books(Id)
);


-- Crear tabla Cliente
CREATE TABLE Cliente (
  Id INT NOT NULL IDENTITY,
  Nombre VARCHAR(100) NOT NULL,
  correo VARCHAR(200) NOT NULL,
  PRIMARY KEY (Id)
);

-- Crear tabla Prestamos
CREATE TABLE Prestamos (
  Id INT NOT NULL IDENTITY,
  ClienteId INT NOT NULL,
  LibroId INT NOT NULL,
  Costo DECIMAL(10, 2) NOT NULL,
  Estado VARCHAR(50) NOT NULL,
  Observacion VARCHAR(200),
  FechaPrestamo DATE NOT NULL,
  FechaDevolucion DATE,
  FOREIGN KEY (ClienteId) REFERENCES Cliente(Id),
  FOREIGN KEY (LibroId) REFERENCES Books(Id),
  PRIMARY KEY (Id)
);



INSERT INTO Authors
(Name, Country)
VALUES
('J.D. Salinger', 'USA'),
('F. Scott. Fitzgerald', 'USA'),
('Jane Austen', 'UK'),
('Scott Hanselman', 'USA'),
('Jason N. Gaylord', 'USA'),
('Pranav Rastogi', 'India'),
('Todd Miranda', 'USA'),
('Christian Wenz', 'USA')
;

INSERT INTO Books (Title)
VALUES
('The Catcher in the Rye'),
('Nine Stories'),
('Franny and Zooey'),
('The Great Gatsby'),
('Tender is the Night'),
('Pride and Prejudice'),
('Professional ASP.NET 4.5 in C# and VB')
;

-- Insertar valores en la tabla Cliente
INSERT INTO Cliente (Nombre, correo)
VALUES
('Juan Pérez', 'juan@example.com'),
('María García', 'maria@example.com'),
('Carlos Rodríguez', 'carlos@example.com'),
('Ana López', 'ana@example.com');

-- Insertar valores en la tabla Prestamos
INSERT INTO Prestamos (ClienteId, LibroId, Costo, Estado, Observacion, FechaPrestamo, FechaDevolucion)
VALUES
(1, 1, 10.99, 'Prestado', 'Libro en buen estado', '2023-06-01', '2023-06-08'),
(2, 3, 8.99, 'Prestado', 'Libro con anotaciones', '2023-06-02', '2023-06-09'),
(3, 5, 12.99, 'Devuelto', 'Sin observaciones', '2023-06-03', '2023-06-10'),
(4, 2, 6.99, 'Prestado', 'Libro en excelente estado', '2023-06-04', NULL);



INSERT INTO BooksAuthors
(BookId, AuthorId)
VALUES
(1, 1),
(2, 1),
(3, 1),
(4, 2),
(5, 2),
(6, 3),
(7, 4),
(7, 5),
(7, 6),
(7, 7),
(7, 8)
;

-- FIN QUERYS


SELECT * FROM Authors
SELECT * FROM Books
SELECT * FROM BooksAuthors

SELECT * FROM Cliente

SELECT * FROM Prestamos


--MOSTRAR LIBROS Y SUS AUTORES
SELECT Books.Title AS Book, Authors.Name AS Author
FROM Books
JOIN BooksAuthors ON Books.Id = BooksAuthors.BookId
JOIN Authors ON Authors.Id = BooksAuthors.AuthorId;

--mostrar los libros prestados
SELECT Cliente.Nombre AS Cliente, Books.Title AS Libro, Prestamos.Costo, Prestamos.Estado, Prestamos.Observacion, Prestamos.FechaPrestamo, Prestamos.FechaDevolucion
FROM Cliente
JOIN Prestamos ON Cliente.Id = Prestamos.ClienteId
JOIN Books ON Prestamos.LibroId = Books.Id
WHERE Prestamos.Estado = 'Prestado';


--mostrar los librs que debe un cliente
SELECT Cliente.Nombre AS Cliente, Books.Title AS Libro
FROM Cliente
JOIN Prestamos ON Cliente.Id = Prestamos.ClienteId
JOIN Books ON Prestamos.LibroId = Books.Id
WHERE Cliente.Nombre = 'Juan Pérez';