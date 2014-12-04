create database PocketQueue;

use PocketQueue;


create table Usuario(
	IDUsuario int identity primary key,
	Nome varchar(50),
	Cpf varchar(20),
	ULogin varchar(20),
	USenha varchar(20),
	TipoUsuario varchar(20),
);

create table Senha(
	IDSenha int identity primary key,
	Criacao Datetime DEFAULT ('12/30/1899 23:59:59'),
	Atendido Datetime DEFAULT ('12/30/1899 23:59:59'),
	Resolvido Datetime DEFAULT ('12/30/1899 23:59:59'),
	Guiche int,
	TipoSenha varchar(20),
	EstadoSenha varchar(20),
	IDUsuario int foreign key references Usuario(IDUsuario),
);

insert into Usuario (Nome, Cpf, ULogin, USenha, TipoUsuario) values ('Gerente', '123', 'Gerente', '123', 'Gerente');
