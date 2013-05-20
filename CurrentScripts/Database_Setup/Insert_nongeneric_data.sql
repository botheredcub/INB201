USE `inb201` ;

-- -----------------------------------------------------
-- Data for table `inb201`.`personnel`
-- -----------------------------------------------------
START TRANSACTION;
USE `inb201`;
INSERT INTO `inb201`.`Personnel` 
(`Password` , `AccessLevel`,  `FirstName` ,  `LastName`,  `MiddleName`,  `Phone`  ,  `Address`,
  `City` ,  `PostCode`,  `Gender` ,  `Email`,  `AccountCode` )


VALUES 
(
MD5('password1'), 'basic','Ryan',
'Joplin','','0421463345','44 wallaby way',
'Brisbane', '4051', 'male','ryanjopo@hotmail.com','FR'
),

(
MD5('password1'), 'basic','Stuart',
'Stirling','','0755332567','320 ocean drive',
'Brisbane', '4030', 'male','stuart@gmail.com','SE'
),

(MD5('abcdef493'), 'moderate','Mustafamansurm',
'Alqanbar','','0756546655','32 scenic Cresent','Gold Coast', 
'4000', 'male','mustafa@gmail.com','HR'
),

(MD5('abcdef493'), 'goverment',
'Patrick','Taylor','middle','1800008584',
'20 Kawana way','Sunshine Coast', '4551', 'male',
'patrick.taylor@hotmail.com','GV'
),

(MD5('passf493'), 'advanced','Hasan',
'Alzhrani','','1800008584','20 Kawana way',
'Sunshine Coast', '4551', 'male',
'patrick.taylor@hotmail.com','AM'
),

(MD5('p13kfd9d0'), 'advanced','Some',
'Person','','180005584','20 warigo way',
'Cairns', '4053', 'female',
'some.one@hotmail.com','AM'
),

(
MD5('password1'), 'basic','John',
'Smith','','0421453645','22 Days way',
'toowoomba', '4262', 'male','rsdopo@hotmail.com','FR'
),

(
MD5('password1'), 'basic','Lara',
'Croft','','041852337','325 green drive',
'Mt Isa', '4880', 'female','lara@gmail.com','SE'
),

(MD5('abcdef493'), 'moderate','Natsu',
'Gradneals','grey','0233445546','12 Erza Drive','Gympie', 
'4000', 'male','fairytale@gmail.com','FR'
),

(MD5('abcdef493'), 'goverment',
'Tsunande','hokage','sakura','1809808584',
'20 Kawana way','Gladstone', '4900', 'female',
'naruto@hotmail.com','GV'
),

(MD5('passf493'), 'advanced','Kakashi',
'Hatake','jirya','5689546345','39 Kawana way',
'Cook', '4551', 'male',
'patrick.taylor@hotmail.com','AM'
),

(MD5('p13kfd9d0'), 'advanced','Some',
'Person','','180005584','20 warigo way',
'Cairns', '4053', 'female',
'some.one@hotmail.com','AM'
);

INSERT INTO `inb201`.`EventsT` 
(`EventCode`,`IncidentAddress`,`EventStatus`, `EventWarning`, `CityName`, `RegionName`,
`EventDate`,`Notes`, `EventUpdatedDate`)
/*DECIMAL(9)  VARCHAR(10) VARCHAR(50) VARCHAR(10) VARCHAR(20) DATETIME'YYYY-MM-DD HH:MM:SS' VARCHAR(125) */ 
VALUES
('FE','44 WALLABY WAY', 	'on-alert',		'High',		'Brisbane', 	'South East','2012-02-02 15:01:22','big fire 2 homes at the moment near factory area','1901-01-01 01-01-01'),
('CY','44 HILLS CREST WAY',	'emergency', 	'high',		'Cairns', 		'Far North', '2013-04-02 15:01:22','heading for coast at cairns','1901-01-01 01-01-01'),
('CY','44 HILLS CREST WAY', 'evacuate', 	'on-alert',	'Diamantina',	'Northern', '2012-02-02 15:01:22','heading for coast at cairns','1901-01-01 01-01-01'),
('CY','44 HILLS CREST WAY',	'on-alert',		'Moderate',	'Lockhart River','Far North','2013-04-02 15:01:22','heading for coast at cairns','1901-01-01 01-01-01'),
('FD','32 mountain street ','on-alert', 	'moderate', 'Scenic Rim', 	'South East','2012-04-02 12:01:22','river at 5.1 m above normal heading towards city','1901-01-01 01-01-01'),
('CY','various Ipswitch',	'evacuate',		'Moderate',	'Ipswich', 		'South East', '2012-04-02 12:01:22','river over 7m','1901-01-01 01-01-01'),
('MD','Great west highway',	'on-alert', 	'Moderate',	'Mt Isa', 		'Northern','2011-11-02 02:01:22','both lanes nolonger on road highway closed','1901-01-01 01-01-01');

INSERT INTO `inb201`.`Incidents` ( `UserID`, `EventID`) 
VALUES
('10000000','1000000'),
('10000001','1000001'),
('10000000','1000002'),
('10000003','1000001'),
('10000002','1000004'),
('10000000','1000005')
;




