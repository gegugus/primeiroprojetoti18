CREATE DATABASE AgendaDB;
GO
 
USE AgendaDB;
GO
 
CREATE TABLE Contatos
(
    ID INT IDENTITY(1,1) PRIMARY KEY,
    Nome NVARCHAR(100),
	Idade INT, 
    Telefone NVARCHAR(20),
    Email NVARCHAR(100),
    DataRegistro DATE
);
GO

SELECT*FROM Contatos
GO