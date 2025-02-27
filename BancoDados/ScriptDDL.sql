CREATE DATABASE lojinha;
GO

USE lojinha;
GO

CREATE TABLE Categoria(
	Id			INT not null IDENTITY PRIMARY KEY,
	Nome		VARCHAR(50),
	Foto		VARCHAR(200),
	ExibirHome	BIT
);

CREATE TABLE Produto(
	Id			INT not null IDENTITY PRIMARY KEY,
	Nome		VARCHAR(100) not null,
	Descricao	VARCHAR(1000),
	CategoriaId	INT not null,
	ValorCusto	NUMERIC(10,2),
	ValorVenda	NUMERIC(10,2) not null,
	QtdeEstoque INT not null DEFAULT 0,
	Destaque	BIT DEFAULT 0,
	FOREIGN KEY	(CategoriaId) REFERENCES Categoria(Id)
);

CREATE TABLE ProdutoFoto(
	Id			INT not null IDENTITY PRIMARY KEY,
	ProdutoId	INT not null,
	Foto		VARCHAR(200) not null,
	Descricao	VARCHAR(100)
	FOREIGN KEY (ProdutoId) REFERENCES Produto(Id)
);