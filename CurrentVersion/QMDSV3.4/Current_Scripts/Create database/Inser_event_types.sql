USE `inb201` ;
-- -----------------------------------------------------
-- insert the data for the event_type table. 
-- -----------------------------------------------------
START TRANSACTION;
USE `inb201`;
INSERT INTO `inb201`.`event_type` (`EventCode`,`EventType`) 
VALUES
('FE','Fire'),
('TS','Tsunami'),
('MN','Monsoon'),
('MD','Mudslide'),
('FD','Flood'),
( 'CY','Cyclone'),
('FS','Firestorm'),
('OT','Other');