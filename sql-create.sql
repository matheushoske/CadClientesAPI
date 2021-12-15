#Criando banco de dados

CREATE DATABASE IF NOT EXISTS `bdclientes` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `bdclientes`;

#Criando usuário rede com senha rede

CREATE USER 'rede'@'localhost' IDENTIFIED BY 'rede';
GRANT ALL PRIVILEGES ON bdclientes.* TO 'rede'@'localhost';
FLUSH PRIVILEGES;

#Criando tabela clientes 

CREATE TABLE IF NOT EXISTS `clientes` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `nome` varchar(50) DEFAULT NULL,
  `dt_nasc` date DEFAULT NULL,
  `cep` int(8) DEFAULT NULL,
  `cidade` varchar(100) DEFAULT NULL,
  `estado` varchar(50) DEFAULT NULL,
  `logradouro` varchar(150) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;

