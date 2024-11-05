-- 1 - CRIAR O BANCO DE DADOS
CREATE DATABASE primeiro_projeto;

-- USAR O BANCO DE DADOS
USE primeiro_projeto;

-- 2 - CRIA TABELA USUÁRIO
CREATE TABLE usuario (
	id INT NOT NULL AUTO_INCREMENT,
	nome VARCHAR(50) NOT NULL,
	sobrenome VARCHAR(150) NOT NULL,
	telefone VARCHAR(15) NOT NULL,
	email VARCHAR(50) NOT NULL,
	genero VARCHAR(20) NOT NULL,
	senha VARCHAR(30) NOT NULL,
	PRIMARY KEY (id)
);

-- 3 - CRIAR TABELA ENDEREÇO
CREATE TABLE endereco (
	id INT NOT NULL AUTO_INCREMENT,
    rua VARCHAR(250) NOT NULL,
    numero VARCHAR(30) NOT NULL,
    bairro VARCHAR(150) NOT NULL,
    cidade VARCHAR(250) NOT NULL,
    complemento VARCHAR(150) NULL,
    cep VARCHAR(9) NOT NULL,
    estado VARCHAR(2) NOT NULL,
    PRIMARY KEY (id)
);

-- 4 - RELACIONAR AS TABELAS USUÁRIO E ENDEREÇO
ALTER TABLE endereco ADD usuario_id INT NOT NULL;

-- ADICIONAR CHAVE ESTRANGEIRA
ALTER TABLE endereco ADD CONSTRAINT FK_usuario FOREIGN KEY (usuario_id) REFERENCES usuario(id);

-- 5 - INSERIR USUARIO
INSERT INTO usuario(nome, sobrenome, telefone, email, genero, senha) 
VALUES ('Jean', 'Godoy', '(55) 984482239', 'jean16omg@gmail.com', 'Masculino', '00110370')

INSERT INTO usuario(nome, sobrenome, telefone, email, genero, senha) 
VALUES ('Clovis', 'Batista', '(55) 984392248', 'clovis@gmail.com', 'Masculino', '12345')

-- 6 - SELECIONAR TODOS OS USUÁRIOS DA TABELA
SELECT * FROM usuario;

-- SELECIONAR UM USUÁRIO ESPECIFICO
SELECT * FROM usuario WHERE id = '1'SELECT * FROM usuario WHERE id = '1'

-- 7 - ALTERAR USUÁRIOS
UPDATE usuario SET telefone = '(11) 994323433' WHERE id = 2;

-- 8 - EXCLUIR USUÁRIOS
DELETE FROM usuario WHeRE id = 3;
DELETE FROM usuario WHERE id IN (2,3)

-- 9 - INSERIR ENDEREÇO 
