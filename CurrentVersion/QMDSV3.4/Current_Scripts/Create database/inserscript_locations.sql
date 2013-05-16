USE `inb201` ;
-- TELLS WHICH DATABASE TO CONECT TO 
SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;

-- -----------------------------------------------------
-- STARTS THE TRANSACTION TO ADD DATA TO THE INB201 DATABASE AND THE LOCATION TABLE
-- -----------------------------------------------------
START TRANSACTION;
USE `inb201`;
INSERT INTO `inb201`.`Location` (`CityName`, `RegionName`, `latitude`, `longitude`) 
-- THE ('','','','') DEFINES HOW THE DATA THATS GOING TO BE PUT IN IS FORMATTED AND 
-- THE PARTS THAT RELATE TO EACH COLLUM
VALUES
-- VALUES TO BE INSERTED INTO THE DATABASE
('Brisbane',		'Brisbane',		'-27.4710107',		'153.0234489'),
('Redlands',		'Brisbane',		'-28.0172605', 		'153.4256987'),
('Moreton Bay', 	'Brisbane',		'-27.2060582', 		'153.250355'),
('Ipswich',			'South East',	'-27.6140934',		'152.7584716'),
('Logan',			'South East', 	'-36.6220096',		'143.4908118'),
('Scenic Rim',		'South East',	'-28.3311621',		'153.4142321'),
('Somerset',		'South East',	'-28.0908676',		'153.3738224'),
('Bundaberg',		'North Coast',	'-24.8653911',		'152.3487394'),
('Cherbourg',		'North Coast',	'-26.2918901',		'151.9558879'),
('Fraser Coast',	'North Coast',	'-25.284258',		'152.846114'),
('Gympie',			'North Coast',	'-26.1902977',		'152.6653914'),
('North Burnett',	'North Coast',	'-25.6200743',		'151.6009743'),
('South Burnett',	'North Coast',	'-26.5387119',		'151.8351607'),
('Sunshine Coast',	'Sunshine Coast',	'-26.64',		'153.07'),
('Balonne',			'South Western',	'-27.9896463',	'147.1577704'),
('Bulloo',			'South Western',	'-28.5553',		'142.83609'),
('Goondiwindi',		'South Western',	'-28.5472061',	'150.3074519'),
('Lockyer Valley',	'South Western',	'-27.55823',	'152.279205'),
('Maranoa',			'South Western',	'-26.7515394',	'148.7373634'),
('Murweh',			'South Western',	'-26.9264294',	'145.7233945'),
('Paroo',			'South Western',	'-27.2761807',	'153.014768'),
('Quilpie',			'South Western',	'-26.6135582',	'144.2687661'),
('Southern Downs',	'South Western',	'-28.219567',	'152.028799'),
('Toowoomba',		'South Western',	'-27.56433',	'151.9539874'),
('Western Downs',	'South Western',	'-19.6332397',	'138.5558252'),
('Banana',			'Central',			'-24.471803',	'150.1282427'),
('Barcaldine',		'Central',			'-23.5524673',	'145.2885214'),
('Barcoo',			'Central',			'-21.060261',	'149.098099'),
('Blackall-Tambo',	'Central',			'-24.3039219',	'146.3572669'),
('Gladstone',		'Central',			'-23.8487083',	'151.2597998'),
('Cent. Highland',	'Central',			'-24.1197822',	'147.6439048'),
('Isaac',			'Central',			'-22.0054102',	'148.0378187'),
('Longreach',		'Central',			'-23.4406575',	'144.2510561'),
('Mackay',			'Central',			'-21.1412101',	'149.1856253'),
('Rockhampton',		'Central',			'-23.3222117',	'150.5124332'),
('Whitsunday',		'Central',			'-20.417506',	'148.5543821'),
('Winton',			'Central',			'-22.3900928',	'143.0390909'),
('Woorabinda',		'Central',			'-24.1283031',	'149.4586171'),
('Burdekin',		'Northern',			'-20.650241',	'146.9773826'),
('Burke',			'Northern',			'-20.6572702',	'141.7442454'),
('Boulia',			'Northern',			'-22.9112852',	'139.9095312'),
('Carpentaria',		'Northern',			'-18.1727886',	'139.918619'),
('Charters Towers',	'Northern',			'-20.0504796',	'146.2538153'),
('Cloncurry',		'Northern',			'-20.7043534',	'140.505613'),
('Diamantina',		'Northern',			'-23.822056',	'141.2631813'),
('Doomadgee',		'Northern',			'-17.9416667',	'138.8283333'),
('Flinders',		'Northern',			'-17.930695',	'140.74178'),
('Hinchinbrook',	'Northern',			'-18.3362903',	'146.2258805'),
('McKinlay',		'Northern',			'-21.2716714',	'141.2894828'),
('Mornington',		'Northern',			'-20.7365468',	'139.4993834'),
('Mt Isa',			'Northern',			'-20.7245148',	'139.49472'),
('Palm Island',		'Northern',			'-18.7364785',	'146.5812638'),
('Richmond',		'Northern',			'-20.7294558',	'143.1416956'),
('Townsville',		'Northern',			'-19.2576268',	'146.8178707'),
('Aurukun',			'Far North',		'-13.3598009',	'141.7287839'),
('Cairns',			'Far North',		'-16.8985465',	'145.7133909'),
('Cassowary Coast',	'Far North',		'-17.8691214',	'146.1063381'),
('Cook',			'Far North',		'-17.2634546',	'145.4799901'),
('Croydon',			'Far North',		'-18.2039217',	'142.2446333'),
('Hopevale',		'Far North',		'-15.2947395',	'145.1122306'),
('Kowanyama',		'Far North',		'-15.4789659',	'141.7414155'),
('Lockhart River',	'Far North',		'-12.7875117',	'143.3445613'),
('Mapoon',			'Far North',		'-12.0191267',	'141.9017344'),
('Napranum',		'Far North',		'-12.683635',	'141.8883451'),
('Nthn Peninsula',	'Far North',		'-12.6238453',	'141.8854939'),
('Pormpuraaw',		'Far North',		'-14.8984997',	'141.6202272'),
('Torres Straight',	'Far North',		'-10.5',		'142.25'),
('Weipa',			'Far North',		'-12.6591475',	'141.8384064'),
('Wujal Wujal',		'Far North',		'-15.9461065',	'145.3186555'),
('Yarrabah',		'Far North',		'-15.9461065',	'145.3186555')
;
