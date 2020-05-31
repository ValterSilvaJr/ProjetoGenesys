
select * from USUARIO
select * from ENDERECO
insert into USUARIO(nome, email, senha) values('Valter Silva','valter@mail.com','12345678');
insert into ENDERECO(logradouro, numero, cep, bairro, cidade, uf, pais, id_usuario) values('Rua dos Bobos','0','00000000','Praça','São Paulo','SP','Brasil', @@IDENTITY);
/*insert into ENDERECO(logradouro, numero, cep, bairro, cidade, uf, pais, id_endereco) 
values('TEST','255','0444','ASSA','SASASASAS','SS','BR', @id_usuario)*/

select u.nome, e.logradouro, e.numero from USUARIO u
inner join ENDERECO e
on u.id_endereco != ''

select u.id_usuario, u.nome, e.logradouro, e.numero, e.id_endereco from USUARIO u
inner join ENDERECO e
on u.id_usuario = e.id_usuario
order by id_usuario

select u.id_usuario, u.nome, e.logradouro, e.numero from ENDERECO e
inner join USUARIO u
on e.id_usuario = u.id_usuario

dbcc checkident (endereco, reseed, 0) /*Comando para resetar a tabela*/
select IDENT_CURRENT('USUARIO') /*Comando para exibir o id atual da tabela*/
