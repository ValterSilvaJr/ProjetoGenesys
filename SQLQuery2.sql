﻿
select * from USUARIO
select * from ENDERECO
select * from CLIENTE
select * from PESSOA_FISICA
select * from PESSOA_JURIDICA
select * from FUNCIONARIO

exec sp_helpconstraint usuario
exec sp_helpconstraint endereco
exec sp_helpconstraint cliente
exec sp_helpconstraint pessoa_fisica
exec sp_helpconstraint pessoa_juridica

/*TESTES TABELA DETALHES USUARIO*/
select u.id_usuario 'ID USUARIO',pf.id_usuario 'ID PF', c.id_cliente 'ID CLIENTE',u.nome, u.email, e.logradouro, e.bairro, c.tipo, pf.cpf, pf.dataNasc from usuario u
inner join endereco e on e.id_usuario = u.id_usuario
inner join cliente c on c.id_usuario = u.id_usuario
inner join PESSOA_FISICA pf on pf.id_usuario = c.id_cliente
where u.id_usuario=8

/*Insere dados nas tabelas relacionadas*/
DECLARE @TranName varchar(20);
SELECT @TranName = 'Inserir Dados PF'

BEGIN TRANSACTION @TranName

	insert into USUARIO(nome, email, senha) values('Valter','valter325@mail.com','12345678');
	
	insert into ENDERECO(id_usuario ,logradouro, numero, cep, bairro, cidade, uf, pais) values(@@IDENTITY,'Rua Três','12B','50882-059','Townsville','Luganenhum','MG','Multiverso');
	
	insert into CLIENTE(id_usuario, tipo) values(@@IDENTITY, 'PF')
	
	insert into PESSOA_FISICA(cpf,id_usuario, dataNasc) values('00044478800', @@IDENTITY, '2010-05-25')

IF @@ERROR = 0
	COMMIT TRANSACTION @TranName
ELSE
	ROLLBACK

/*PJ*/
DECLARE @TranName varchar(20);
SELECT @TranName = 'Inserir Dados PJ'

BEGIN TRANSACTION @TranName

	insert into USUARIO(nome, email, senha) values('Empresa X','empresax@mail.com','12345678');
	
	insert into ENDERECO(id_usuario ,logradouro, numero, cep, bairro, cidade, uf, pais) values(@@IDENTITY,'Avenida Giovani Gronch','2000','50882-059','Centro Empresarial','São Paulo','SP','Brasil');
	
	insert into CLIENTE(id_usuario, tipo) values(@@IDENTITY, 'PJ')
	
	insert into PESSOA_JURIDICA(cnpj,id_usuario, inscricao_estadual, razao_social, nome_fantasia) values('11111111000100', @@IDENTITY, '11111111','Empresa X S.A.','Empresa Experience')

IF @@ERROR = 0
	COMMIT TRANSACTION @TranName
ELSE
	ROLLBACK

/*FCN*/
DECLARE @TranName varchar(20);
SELECT @TranName = 'Inserir Dados FCN'

BEGIN TRANSACTION @TranName

	insert into USUARIO(nome, email, senha) values('Valter','valter.admin@genesys.com','12345678');
	
	insert into ENDERECO(id_usuario ,logradouro, numero, cep, bairro, cidade, uf, pais) values(@@IDENTITY,'Rua dos Pinheiros','545','04488000','Pinheiros','São Paulo','SP','Brasil');

	insert into FUNCIONARIO(id_usuario, cargo, setor, turno) values(@@IDENTITY, 'Desenvolvedor Front-end','Mobile','Noite');
	
IF @@ERROR = 0
	COMMIT TRANSACTION @TranName
ELSE
	ROLLBACK





/*TESTES*/
select u.nome, e.logradouro, e.numero from USUARIO u
inner join ENDERECO e on e.id_endereco = u.id_usuario

select u.id_usuario, u.nome, e.logradouro, e.numero, e.id_endereco from USUARIO u
inner join ENDERECO e on u.id_usuario = e.id_usuario
order by id_usuario

select u.id_usuario, u.nome, e.logradouro, e.numero from ENDERECO e
inner join USUARIO u on e.id_usuario = u.id_usuario

select * from USUARIO where email like 'v%'

select nome from usuario where id_usuario=1;

SELECT u.id_usuario, u.nome, u.email, c.tipo FROM USUARIO u
INNER JOIN CLIENTE c on c.id_usuario = u.id_usuario
where u.id_usuario = 4;

BEGIN TRANSACTION
UPDATE USUARIO 
	SET nome='José', email='test688@mail.com', senha='1234ABC' 
	where id_usuario=8;

UPDATE ENDERECO 
	SET logradouro='Rua 8000', numero='22' FROM ENDERECO e
	inner join USUARIO u ON u.id_usuario = e.id_usuario WHERE u.id_usuario = 8;

UPDATE PESSOA_FISICA
	SET cpf='00045688000' FROM PESSOA_FISICA pf
	inner join USUARIO u ON u.id_usuario = pf.id_usuario WHERE u.id_usuario = 1;
COMMIT

UPDATE PESSOA_JURIDICA
	SET cnpj='12333222000188' FROM PESSOA_JURIDICA pj
	inner join CLIENTE c ON c.id_cliente = pj.id_cliente WHERE c.id_cliente = 8;

UPDATE FUNCIONARIO
	SET cargo='C# Developer' FROM FUNCIONARIO f
	inner join USUARIO u ON u.id_usuario = f.id_usuario WHERE u.id_usuario=2;




/*Faz uma busca nas tabelas relacionadas*/
select u.id_usuario 'ID', c.id_cliente 'ID CLIENTE', e.id_endereco 'ID END', u.nome 'NOME COMPLETO', pf.cpf 'CPF', pf.dataNasc 'IDADE', e.logradouro 'LOGRADOURO', e.numero 'N', e.bairro 'BAIRRO', e.cidade 'CIDADE', e.uf 'ESTADO', e.pais 'PAÍS' from USUARIO u
inner join ENDERECO e on e.id_usuario = u.id_usuario
inner join CLIENTE c on c.id_usuario = u.id_usuario
inner join PESSOA_FISICA pf on pf.id_usuario = c.id_usuario


select u.id_usuario 'ID', c.id_cliente 'ID CLIENTE', e.id_endereco 'ID END', u.nome 'NOME COMPLETO', pj.razao_social 'RAZÃO SOCIAL', pj.nome_fantasia 'NOME FANTASIA', pj.cnpj 'CNPJ', pj.inscricao_estadual 'I.E.', e.logradouro 'LOGRADOURO', e.numero 'N', e.bairro 'BAIRRO', e.cidade 'CIDADE', e.uf 'ESTADO', e.pais 'PAÍS' from USUARIO u
inner join ENDERECO e on e.id_usuario = u.id_usuario
inner join CLIENTE c on c.id_usuario = u.id_usuario
inner join PESSOA_JURIDICA pj on pj.id_usuario = c.id_usuario


select u.id_usuario, u.nome, u.email, e.logradouro, e.numero, f.id_funcionario, f.cargo, f.setor, f.turno from USUARIO u
inner join ENDERECO e ON e.id_usuario = u.id_usuario
inner join FUNCIONARIO f ON f.id_usuario = u.id_usuario




/*Filtra os usuários da tabela pelo ID*/
select u.id_usuario 'ID', c.id_cliente 'ID CLIENTE', e.id_endereco 'ID END', u.nome 'NOME COMPLETO', pf.cpf 'CPF', pf.dataNasc 'IDADE', e.logradouro 'LOGRADOURO', e.numero 'N', e.bairro 'BAIRRO', e.cidade 'CIDADE', e.uf 'ESTADO', e.pais 'PAÍS' from CLIENTE c
inner join USUARIO u on u.id_usuario = c.id_usuario
inner join PESSOA_FISICA pf on pf.id_usuario = c.id_usuario
inner join ENDERECO e on e.id_usuario = u.id_usuario
where u.id_usuario = 8




/*Comando para resetar a tabela*/
dbcc checkident (usuario, reseed, 0) 
dbcc checkident (endereco, reseed, 0)
dbcc checkident (cliente, reseed, 0)
dbcc checkident (funcionario, reseed, 0)




/*Comando para exibir o id atual da tabela*/
select IDENT_CURRENT('USUARIO') 




/*MODIFICAÇÕES NAS TABELAS*/
alter table pessoa_fisica add id_cliente int constraint FK_CLIENTE_PF foreign key(id_cliente) references cliente(id_cliente) on delete cascade;
alter table CLIENTE add id_usuario int CONSTRAINT FK_ID_USUARIO FOREIGN KEY (id_usuario) REFERENCES USUARIO (id_usuario) on delete cascade;
alter table endereco add id_usuario int CONSTRAINT FK_ID_USUARIO_ENDERECO FOREIGN KEY (id_usuario) REFERENCES USUARIO (id_usuario) on delete cascade;




delete from USUARIO