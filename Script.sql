-- CRIANDO O BANCO DE DADOS

CREATE DATABASE DBProjeto;

-- USANDO O BANCO DE DADOS

USE DBProjeto;

-- CRIANDO AS TABELAS DO BANCO DE DADOS

CREATE TABLE tbLogin(
codLogin int primary key auto_increment,
usuario varchar(40),
senha varchar(40)
);

-- CONSULTANDO AS TABELAS DO BANCO

SELECT * FROM tbLogin;

-- Inserindo dados na tabela
insert into tbLogin(usuario,senha) values("cidade","city@2025"); 
insert into tbLogin(usuario,senha) values("gustavo","12345678"); 