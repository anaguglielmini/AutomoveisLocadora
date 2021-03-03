create database if not exists locadoradb;
use locadoradb;

CREATE TABLE `cad_veiculo` (
  `id_veiculo` int NOT NULL AUTO_INCREMENT,
  `placa_veiculo` int NOT NULL,
  `tipo_veiculo` boolean NOT NULL,
  `desc_veiculo` varchar(100) NOT NULL,
  `marca_veiculo` varchar(45) NOT NULL,
  `modelo_veiculo` varchar(45) NOT NULL,
  `stts_veiculo` boolean NOT NULL,
  PRIMARY KEY (`id_veiculo`),
  UNIQUE KEY `placa_veiculo_UNIQUE` (`placa_veiculo`),
  UNIQUE KEY `id_veiculo_UNIQUE` (`id_veiculo`)
);

CREATE TABLE `cad_cliente` (
  `id_cliente` int NOT NULL AUTO_INCREMENT,
  `nome_cliente` varchar(80) NOT NULL,
  `cpf_cliente` int NOT NULL,
  `idade_cliente` int NOT NULL,
  `cnh_cliente` int NOT NULL,
  `endereco_cliente` varchar(80) NOT NULL,
  `telefone_cliente` int NOT NULL,
  `sttsConta_cliente` boolean NOT NULL,
  PRIMARY KEY (`id_cliente`),
  UNIQUE KEY `id_cliente_UNIQUE` (`id_cliente`),
  UNIQUE KEY `cpf_cliente_UNIQUE` (`cpf_cliente`),
  UNIQUE KEY `cnh_cliente_UNIQUE` (`cnh_cliente`)
);

CREATE TABLE `aluguel` (
  `id_aluguel` int NOT NULL AUTO_INCREMENT,
  `data_emprestimo` date NOT NULL,
  `data_devolucao` date NOT NULL,
  `id_veiculo` int NOT NULL,
  `id_cliente` int NOT NULL,
  PRIMARY KEY (`id_aluguel`),
  UNIQUE KEY `id_aluguel_UNIQUE` (`id_aluguel`)
);

CREATE TABLE `pagamento` (
  `id_pagamento` int NOT NULL AUTO_INCREMENT,
  `cartao` boolean NOT NULL,
  `dinheiro` boolean NOT NULL,
  `multa` boolean NOT NULL,
  `id_aluguel` int NOT NULL,
  PRIMARY KEY (`id_pagamento`),
  UNIQUE KEY `id_pagamento_UNIQUE` (`id_pagamento`),
  UNIQUE KEY `id_cliente_UNIQUE` (`id_aluguel`),
  UNIQUE KEY `id_veiculo_UNIQUE` (`multa`)
);

select * from pagamento;
select * from aluguel;
select * from cad_cliente;
select * from cad_veiculo;

