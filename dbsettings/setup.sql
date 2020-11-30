CREATE DATABASE MSSQL_DB=productmanager;
GO
USE productmanager;
GO
CREATE TABLE Produtos (ID_PRODUTO uuid, NOME_PRODUTO nvarchar(200), VALOR_PRODUTO decimal(18,2), IMAGEMURI_PRODUTO nvarchar(500));
GO