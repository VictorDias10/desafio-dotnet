  CREATE TABLE `escola`.`alunos` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(100) NOT NULL,
  `notaPrimeiroSemestre` FLOAT NOT NULL,
  `notaSegundoSemestre` FLOAT NOT NULL,
  `ano` INT NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `id_UNIQUE` (`id` ASC) VISIBLE);