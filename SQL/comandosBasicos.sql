select * from cliente;
insert into cliente(Nome, CPF, Telefone, Email) values('Paulo Renato Conceição Mendes', '055.280.133-05', '(98)984282846', 'mendesdpn@gmail.com');
insert into cliente(Nome, CPF, Telefone) values('Agnaldo Sanches', '032.321.542-55', '(98)984443322');

select * from pet;
insert into pet(nome, dataDeNascimento, rga, raça, idcliente) values('mel', '2008-11-11', '532.678', 'pudle', 2);
insert into pet(nome, dataDeNascimento, rga, raça, idcliente) values('lola', '2008-11-11', '532.678', 'pudle', 2);
insert into pet(nome, dataDeNascimento, rga, raça, idcliente) values('malu', '2008-11-11', '532.678', 'pudle', 2);

select * from tratamento;
insert into tratamento(nome, valor, duracaoMedia) values('massagem', 24.5, '00:30:00');
insert into tratamento(nome, valor, duracaoMedia) values('banho', 8.0, '00:25:00');

select * from pettratamento;
insert into pettratamento(idPet, idTratamento, dataHora) values(1, 1, '2014-11-27 12:00:00');
insert into pettratamento(idPet, idTratamento, dataHora, estado) values(2, 2, '2014-11-27 12:00:00', true);