drop database if exists locadoradb;
create database if not exists locadoradb;
use locadoradb;

CREATE TABLE `cad_veiculo` (
  `id_veiculo` int NOT NULL AUTO_INCREMENT,
  `placa_veiculo` char(7) NOT NULL,
  `desc_veiculo` varchar(100) NOT NULL,
  `marca_veiculo` varchar(45) NOT NULL,
  `modelo_veiculo` varchar(45) NOT NULL,
  `preco_veiculo` int NOT NULL, 
  `stts_veiculo` boolean NOT NULL,
  `data_emprestimo` date,
  `data_devolucao` date,
  PRIMARY KEY (`id_veiculo`),
  UNIQUE KEY `id_veiculo_UNIQUE` (`id_veiculo`)
);

insert into cad_veiculo (placa_veiculo, desc_veiculo, marca_veiculo, modelo_veiculo, preco_veiculo, stts_veiculo, data_emprestimo, data_devolucao)
values ('abc4321', 'Vermelho, quatro portas, arranhão no lado e piercing no retrovisor', 'Fiat', 'Jorge','100', '1', '2021-02-01', '2021-02-10');

insert into cad_veiculo (placa_veiculo, desc_veiculo, marca_veiculo, modelo_veiculo, preco_veiculo, stts_veiculo, data_emprestimo, data_devolucao)
values ('del0142', 'Cinza, duas portas, viaja no tempo', 'Delorian', 'DMC','10000', '1', '2021-01-03', '2021-01-20');

insert into cad_veiculo (placa_veiculo, desc_veiculo, marca_veiculo, modelo_veiculo, preco_veiculo, stts_veiculo, data_emprestimo, data_devolucao)
values ('ala2021', 'Verde, 5 portas, porta malas gigante, rodas fininhas', 'Renault', 'Duster','1000', '1', '2021-03-03', '2021-03-30');


insert into cad_veiculo (placa_veiculo, desc_veiculo, marca_veiculo, modelo_veiculo, preco_veiculo, stts_veiculo, data_emprestimo, data_devolucao)
values ('ben1522', 'Azul preto, quatro portas, perfeito', 'Rolls royce', 'Sweptail','1000', '0', null, null);

select * from cad_veiculo;