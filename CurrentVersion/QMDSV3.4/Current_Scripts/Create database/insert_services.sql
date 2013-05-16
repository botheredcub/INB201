USE `inb201` ;

SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;

-- -----------------------------------------------------
-- Data for table `inb201`.`personnel`
-- -----------------------------------------------------
START TRANSACTION;
USE `inb201`;
INSERT INTO `inb201`.`services` (`AccountType`,`AccountCode` ) 
VALUES
('FIRE_RESCUE', 'FR'),
('POLICE', 'PL'),
('SES','SE'),
('AMBULANCE','AM'),
('MILITARY', 'ML'),
('DISASTER_MANGE','DM'),
('GOVERMENT', 'GV'),
('HUMAN_RESOURCE', 'HR'),
('OTHER', 'OT');