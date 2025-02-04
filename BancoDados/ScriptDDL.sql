CREATE DATABASE lojinha;

USE lojinha;

CREATE TABLE Categoria(
	Id			INT not null IDENTITY PRIMARY KEY,
	Nome		VARCHAR(50),
	Foto		VARCHAR(200),
	ExibirHome	BIT
);