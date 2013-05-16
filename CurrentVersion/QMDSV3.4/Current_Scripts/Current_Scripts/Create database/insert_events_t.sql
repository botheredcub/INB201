USE `inb201` ;

SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;

-- -----------------------------------------------------
-- Data for table `inb201`.`personnel`
-- -----------------------------------------------------
START TRANSACTION;
USE `inb201`;
INSERT INTO `inb201`.`Events_t` 
(`EventCode`,`IncidentAddress`,`EventStatus`, `EventWarning`, `CityName`,
`Event_Date`,`Notes`, `Event_updated_Date`)
/*DECIMAL(9)  VARCHAR(10) VARCHAR(50) VARCHAR(10) VARCHAR(20) DATETIME'YYYY-MM-DD HH:MM:SS' VARCHAR(125) */ 
VALUES
('FE','44 WALLABY WAY', 	'on-alert',		'HIGH','Brisbane','2012-02-02 15:01:22','big fire 2 homes at the moment near factory area','1901-01-01 01-01-01'),
('CY','44 HILLS CREST WAY',	'emergency', 	'high','CAIRNS','2013-04-02 15:01:22','heading for coast at cairns','1901-01-01 01-01-01'),
('CY','44 HILLS CREST WAY', 'evacuate', 	'on-alert','Diamantina','2012-02-02 15:01:22','heading for coast at cairns','1901-01-01 01-01-01'),
('CY','44 HILLS CREST WAY',	'on-alert',		'Moderate','Lockhart River','2013-04-02 15:01:22','heading for coast at cairns','1901-01-01 01-01-01'),
('FD','32 mountain street ','on-alert', 	'moderate', 'Scenic Rim','2012-04-02 12:01:22','river at 5.1 m above normal heading towards city','1901-01-01 01-01-01'),
('CY','various Ipswitch',	'evacuate',		'Moderate','Ipswich','2012-04-02 12:01:22','river over 7m','1901-01-01 01-01-01'),
('MD','Great west highway',	'on-alert', 	'Moderate','Mt Isa','2011-11-02 02:01:22','both lanes nolonger on road highway closed','1901-01-01 01-01-01');




