IF OBJECT_ID('dbo.Clientes', 'U') IS NULL
BEGIN
	CREATE TABLE dbo.Clientes
	(
		IdCliente			INT	IDENTITY(1,1) PRIMARY KEY NOT NULL,
		Nome				VARCHAR(50)  NOT NULL,
		Idade				INT NOT NULL
	)
END