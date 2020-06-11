
select * from USUARIO
select * from ENDERECO
select * from CLIENTE
select * from PESSOA_FISICA
select * from PESSOA_JURIDICA
select * from FUNCIONARIO

/*Insere dados nas tabelas relacionadas*/
DECLARE @TranName varchar(20);
SELECT @TranName = 'Inserir Dados PF'

BEGIN TRANSACTION @TranName

	insert into USUARIO(nome, email, senha) values('Roberto','roberto@mail.com','12345678');
	
	insert into ENDERECO(id_usuario ,logradouro, numero, cep, bairro, cidade, uf, pais) values(@@IDENTITY,'Rua Três','12B','50882-059','Townsville','Luganenhum','MG','Multiverso');
	
	insert into CLIENTE(id_usuario, tipo) values(@@IDENTITY, 'PF')
	
	insert into PESSOA_FISICA(cpf,id_cliente, dataNasc) values('13177678800', @@IDENTITY, '2010-05-25')
	
COMMIT TRANSACTION @TranName
	

/*TESTES*/
select u.nome, e.logradouro, e.numero from USUARIO u
inner join ENDERECO e on e.id_endereco = u.id_usuario

select u.id_usuario, u.nome, e.logradouro, e.numero, e.id_endereco from USUARIO u
inner join ENDERECO e on u.id_usuario = e.id_usuario
order by id_usuario

select u.id_usuario, u.nome, e.logradouro, e.numero from ENDERECO e
inner join USUARIO u on e.id_usuario = u.id_usuario

select * from USUARIO where email like 'v%'

/*Faz uma busca nas tabelas relacionadas*/
select u.id_usuario 'ID', c.id_cliente 'ID CLIENTE', e.id_endereco 'ID END', u.nome 'NOME COMPLETO', pf.cpf 'CPF', pf.dataNasc 'IDADE', e.logradouro 'LOGRADOURO', e.numero 'N', e.bairro 'BAIRRO', e.cidade 'CIDADE', e.uf 'ESTADO', e.pais 'PAÍS' from CLIENTE c
inner join USUARIO u on u.id_usuario = c.id_usuario
inner join PESSOA_FISICA pf on pf.id_cliente = c.id_usuario
inner join ENDERECO e on e.id_usuario = u.id_usuario

/*Filtra os usuários da tabela pelo ID*/
select u.id_usuario 'ID', c.id_cliente 'ID CLIENTE', e.id_endereco 'ID END', u.nome 'NOME COMPLETO', pf.cpf 'CPF', pf.dataNasc 'IDADE', e.logradouro 'LOGRADOURO', e.numero 'N', e.bairro 'BAIRRO', e.cidade 'CIDADE', e.uf 'ESTADO', e.pais 'PAÍS' from CLIENTE c
inner join USUARIO u on u.id_usuario = c.id_usuario
inner join PESSOA_FISICA pf on pf.id_cliente = c.id_usuario
inner join ENDERECO e on e.id_usuario = u.id_usuario
where u.id_usuario = 1

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