-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Tempo de geração: 17-Nov-2021 às 19:45
-- Versão do servidor: 8.0.21
-- versão do PHP: 7.3.21

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `chilli_beans`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `oculos`
--

DROP TABLE IF EXISTS `oculos`;
CREATE TABLE IF NOT EXISTS `oculos` (
  `idOculos` int NOT NULL AUTO_INCREMENT,
  `nome` varchar(100) NOT NULL,
  `cor` varchar(65) NOT NULL,
  `tipo` varchar(65) NOT NULL,
  `preco` decimal(10,2) NOT NULL,
  PRIMARY KEY (`idOculos`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Extraindo dados da tabela `oculos`
--

INSERT INTO `oculos` (`idOculos`, `nome`, `cor`, `tipo`, `preco`) VALUES
(1, 'Óculos de Luxo', 'Dolrado', 'Sol', '1699.00');

-- --------------------------------------------------------

--
-- Estrutura da tabela `usuario`
--

DROP TABLE IF EXISTS `usuario`;
CREATE TABLE IF NOT EXISTS `usuario` (
  `idUsuario` int NOT NULL AUTO_INCREMENT,
  `email` varchar(85) NOT NULL,
  `senha` int NOT NULL,
  PRIMARY KEY (`idUsuario`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Extraindo dados da tabela `usuario`
--

INSERT INTO `usuario` (`idUsuario`, `email`, `senha`) VALUES
(1, '11901055@aluno.cotemig.com.br', 12345);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
