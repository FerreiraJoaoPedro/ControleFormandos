CREATE DATABASE IF NOT EXISTS `controleformandos`;
USE `controleformandos`;

CREATE TABLE `formando` (
  `id` int(10) UNSIGNED NOT NULL,
  `nome` varchar(45) NOT NULL,
  `email` varchar(45) NOT NULL,
  `telefone` varchar(55) DEFAULT NULL,
  `formatura_id` int(10) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

INSERT INTO `formando` (`id`, `nome`, `email`, `telefone`, `formatura_id`) VALUES
(2, 'Agnaldo Pereira', 'agnaldo02@gmail.com', '33761565', 4);

CREATE TABLE `formatura` (
  `id` int(10) UNSIGNED NOT NULL,
  `endereco` varchar(100) NOT NULL,
  `horarioInicio` varchar(20) NOT NULL,
  `dataInicio` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

INSERT INTO `formatura` (`id`, `endereco`, `horarioInicio`, `dataInicio`) VALUES
(2, 'Rua Bacuri, 180', '18:00', '04/11/2021'),
(4, 'Rua Marea, 180', '22:00', '30/11/2021');

CREATE TABLE `usuario` (
  `id` int(10) UNSIGNED NOT NULL,
  `nome` varchar(45) NOT NULL,
  `email` varchar(45) NOT NULL,
  `senha` varchar(55) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

INSERT INTO `usuario` (`id`, `nome`, `email`, `senha`) VALUES
(1, 'Joao Pedro Ferreira', 'joaozin@gmail', '123456');

ALTER TABLE `formando`
  ADD PRIMARY KEY (`id`),
  ADD KEY `formatura_id` (`formatura_id`);

ALTER TABLE `formatura`
  ADD PRIMARY KEY (`id`);

ALTER TABLE `usuario`
  ADD PRIMARY KEY (`id`);

ALTER TABLE `formando`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

ALTER TABLE `formatura`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

ALTER TABLE `usuario`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

ALTER TABLE `formando`
  ADD CONSTRAINT `formando_ibfk_1` FOREIGN KEY (`formatura_id`) REFERENCES `formatura` (`id`);
COMMIT;