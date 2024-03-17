create database MercuryProject;
use MercuryProject;

CREATE TABLE TblLogin (
	cd_login int PRIMARY KEY auto_increment,
    user_login varchar(20) NOT NULL unique,
	senha_login varchar(15) NOT NULL
);

CREATE TABLE TblCliente (
	cd_cliente int PRIMARY KEY auto_increment,
    cd_login int,
	nm_cliente varchar(40) NOT NULL,
	no_CPF char(11) NOT NULL,
	email varchar(50) NOT NULL,
	no_telefone char(11) NOT NULL,
	dt_nascimento datetime NOT NULL,
	nm_logradouro varchar(60) NOT NULL,
	no_logradouro varchar(4) NOT NULL,
	nm_cidade varchar(30) NOT NULL,
	nm_bairro varchar(30) NOT NULL,
	no_CEP char(8) NOT NULL,
	sg_UF char(2) NOT NULL,
    FOREIGN KEY(cd_login) REFERENCES TblLogin (cd_login)
);

CREATE TABLE TblFuncionario (
	cd_funcionario int PRIMARY KEY auto_increment,
	cd_login int,
	no_CPF char(11) NOT NULL,
	email varchar(50) NOT NULL,
	nm_funcionario varchar(40) NOT NULL,
	no_telefone char(11) NOT NULL,
	nm_logradouro varchar(60) NOT NULL,
	no_logradouro varchar(4) NOT NULL,
	nm_cidade varchar(30) NOT NULL,
	nm_bairro varchar(30) NOT NULL,
	no_CEP char(8) NOT NULL,
	sg_UF char(2) NOT NULL,
    FOREIGN KEY(cd_login) REFERENCES TblLogin (cd_login)
);

CREATE TABLE TblVeiculos (
	cd_veiculo int PRIMARY KEY auto_increment,
    no_chassi char(17) NOT NULL unique,
    nm_marca varchar(25) NOT NULL,
    ds_veiculo varchar(60) NOT NULL,
    ds_modelo varchar(20) NOT NULL,
	ds_cor varchar(25) NOT NULL,
	no_placa char(7) NOT NULL unique,
	nm_fabricante varchar(30) NOT NULL
);

CREATE TABLE TblCompra (
	cd_compra int PRIMARY KEY auto_increment,
    cd_login int NOT NULL,
	dt_compra datetime NOT NULL,
	vl_compra decimal(10, 2) NOT NULL,
	qtnd_produto varchar(4) NOT NULL,
    FOREIGN KEY(cd_login) REFERENCES TblLogin (cd_login)
);

CREATE TABLE TblPagamento (
	cd_pagamento int PRIMARY KEY auto_increment,
    cd_compra int NOT NULL,
	ds_pagamento varchar(60) NOT NULL,
	dt_pagamento datetime NOT NULL,
	vl_total decimal(10, 2) NOT NULL,
    FOREIGN KEY(cd_compra) REFERENCES TblCompra (cd_compra)
);

CREATE TABLE TblItens_compra (
	cd_veiculo int NOT NULL,
	cd_compra int NOT NULL,
	cd_pagamento int NOT NULL,
	FOREIGN KEY(cd_veiculo) REFERENCES TblVeiculos (cd_veiculo),
	FOREIGN KEY(cd_compra) REFERENCES TblCompra (cd_compra),
	FOREIGN KEY(cd_pagamento) REFERENCES TblPagamento (cd_pagamento)
);

DELIMITER $$
CREATE PROCEDURE UpdateCliente(id int, nome varChar(40), cpf char(11), emailCli varChar(50), telefone char(11), nascimento datetime, nomeLogradouro varChar(60), Numlogradouro varChar(4), cidade varChar(30), bairro varChar(30), CEP char(8), UF char(2))
	BEGIN
		UPDATE tblCliente 
        SET nm_cliente = nome, no_CPF = cpf, email = emailCli, no_telefone = telefone, dt_nascimento = nascimento, nm_logradouro = nomeLogradouro, no_logradouro = NumLogradouro, nm_cidade = cidade, nm_bairro = bairro, no_CEP = CEP, sg_UF = UF
        WHERE cd_cliente = id;
	END
$$ DELIMITER ;


select * from TblCliente;
select * from TblFuncionario;
select * from TblVeiculos;
select * from TblCompra;
select * from TblLogin;
select * from TblItens_compra;
select * from TblPagamento;

desc TblCliente;
desc TblFuncionario;
desc TblVeiculos;
desc TblCompra;
desc TblLogin;
desc TblItens_compra;
desc TblPagamento;