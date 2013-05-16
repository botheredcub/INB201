USE `inb201` ;

-- -----------------------------------------------------
-- Data for table `inb201`.`personnel`
-- -----------------------------------------------------
START TRANSACTION;
USE `inb201`;
INSERT INTO `inb201`.`personnel` 
(`Password` , `Access_Level`,  `F_name` ,  `L_name`,  `M_name`,  `Phone`  ,  `Address`,
  `City` ,  `PostCode`,  `gender` ,  `email`,  `AccountCode` )


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

