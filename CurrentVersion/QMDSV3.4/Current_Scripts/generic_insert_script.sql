USE `inb201` ;

SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;

-- -----------------------------------------------------
-- Data for table `inb201`.`personnel`
-- -----------------------------------------------------
START TRANSACTION;
USE `inb201`;
INSERT INTO `inb201`.`personnel` 
(`UserID`  , `Password` ,  `F_name` ,  `L_name`,  `M_name`,  `Phone`  ,  `Address`,
  `City` ,  `PostCode`,  `gender` ,  `email`,  `AccountCode` )
/*DECIMAL(8) , VARCHAR(10) ,  VARCHAR(30),   VARCHAR(30),
 VARCHAR(30)null , DECIMAL(10) VARCHAR(60) VARCHAR(20) DECIMAL(4)
 VARCHAR(6) VARCHAR(40) CHAR(2) */

*/ 
VALUES
('','','','','','','')