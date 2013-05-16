SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';
-- Create database`inb201`
CREATE SCHEMA IF NOT EXISTS `inb201` DEFAULT CHARACTER SET utf8 ;
USE `inb201` ;
-- use the database`inb201` to process the following transactions

-- -----------------------------------------------------
-- Create Table `inb201`.`services`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `inb201`.`services` (
  `AccountCode` CHAR(2) NOT NULL ,
  `AccountType` VARCHAR(15) NOT NULL ,
  PRIMARY KEY (`AccountCode`, `AccountType`),
  check(AccountCode in('FR', 'SE','AM','ML', 'DM','GV', 'HR', 'OT','PL'))
/* check is a constraint it makes sure values that are inserted in a row are only the
 allowed values or specified values provided within the in (). if not sql will not
allow the transaction to proceed.*/
)

DEFAULT CHARACTER SET = utf8;

-- -----------------------------------------------------
-- Table `inb201`.`personnel`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `inb201`.`personnel` (
  `UserID` INT NOT NULL AUTO_INCREMENT,
  `Password` VARCHAR(32) NOT NULL ,
  `Access_Level` VARCHAR(10) NOT NULL ,
  `F_name` VARCHAR(30) NOT NULL ,
  `L_name` VARCHAR(30) NOT NULL ,
  `M_name` VARCHAR(30),
  `Phone` DECIMAL(10) NOT NULL ,
  `Address` VARCHAR(60) NOT NULL ,
  `City` VARCHAR(20) NOT NULL ,
  `PostCode` DECIMAL(4) NOT NULL ,
  `gender` VARCHAR(6) NOT NULL ,
  `email` VARCHAR(40) NULL ,
  `AccountCode` CHAR(2) NOT NULL ,
  PRIMARY KEY (`UserID`, `Phone`, `F_name`) ,
  UNIQUE (`UserID`),
  Check (gender in('male', 'female')), 
  Check (PostCode between 2400 and 5999),
  Check (UserID between 10000000 and 999999999),
  Check (Access_Level in ('basic','moderate', 'advanced', 'goverment')),
  FOREIGN KEY (`AccountCode` ) REFERENCES `inb201`.`services` (`AccountCode`)
	ON UPDATE RESTRICT
	ON DELETE RESTRICT
 /*as all valid post codes in queensalnd according to 
Australia post are within this range. this also takes into account people who live on the border*/ 
)
ENGINE = InnoDB -- ensures that the database & table is added to the data dictionary.
DEFAULT CHARACTER SET = utf8; 
-- makes certain the database knows what charecter set your using.



-- -----------------------------------------------------
-- Create Table `inb201`.`Location`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `inb201`.`Location` (
  `CityName` VARCHAR(20) NOT NULL ,
  `RegionName` VARCHAR(15) NOT NULL ,
  `latitude` double NOT NULL ,
  `longitude` double NOT NULL,
  PRIMARY KEY (`CityName`, `RegionName`),
  UNIQUE (`CityName`), 
   Check (latitude between -10.0000 and -40.0000 ),
   Check (longitude between 100.0000 and 160.0000 ),
   Check (RegionName in('Brisbane', 'Gold Coast','Sunshine Coast',
		'Far North', 'South East','South Western', 'Central', 
		'Northern', 'North Coast'))
)-- confines the regionname to the following values only 
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;

CREATE  TABLE IF NOT EXISTS `inb201`.`event_type` (
  `EventCode` CHAR(2) NOT NULL ,
  `EventType` VARCHAR(10) NOT NULL ,
  PRIMARY KEY (`EventCode`, `EventType`) ,
  check(EventType in('Fire', 'Tsunami','Monsoon','Mudslide', 'Flood','Cyclone', 'Firestorm', 'Other')),
  check(EventCode in('FE', 'TS','MN','MD', 'FD','CY', 'FS', 'OT'))
 )
ENGINE = InnoDB 
DEFAULT CHARACTER SET = utf8;



-- -----------------------------------------------------
-- Table `inb201`.`events_table`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `inb201`.`Events_T` (
    `Event_ID` INT NOT NULL AUTO_INCREMENT,
	`EventCode` CHAR(2) NOT NULL ,
	`IncidentAddress` VARCHAR(50) NOT NULL ,
	`EventStatus` VARCHAR(10) NOT NULL ,
	`EventWarning` VARCHAR(11) NOT NULL ,
	`CityName` VARCHAR(20) NOT NULL ,
    `Event_Date` DATETIME DEFAULT CURRENT_TIMESTAMP NOT NULL ,-- 'YYYY-MM-DD HH:MM:SS' format 
    `Notes` VARCHAR(125), 
    `Event_updated_Date` DATETIME DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`Event_ID`, `Event_Date`),
	FOREIGN KEY (`EventCode`) REFERENCES `inb201`.`event_type` (`EventCode`) 
	ON UPDATE RESTRICT
	ON DELETE RESTRICT,
   Check (EventStatus in('normal', 'Safe', 'on-alert','evacuate','emergency')),
   Check (EventWarning in('Deffinate','High', 'Moderate', 'Low'))
)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;

CREATE  TABLE IF NOT EXISTS `inb201`.`Incidents` (
  `UserID` INT NOT NULL  ,
  `Event_ID` INT NOT NULL ,
  `Responded_DateTime` DATETIME DEFAULT CURRENT_TIMESTAMP,
  `Finalized_DateTime` DATETIME DEFAULT CURRENT_TIMESTAMP,
	PRIMARY KEY (`UserID`, `Event_ID`),
	FOREIGN KEY (`UserID`) REFERENCES `inb201`.`personnel`  (`UserID`)
	ON UPDATE RESTRICT
	ON DELETE RESTRICT,
	FOREIGN KEY (`Event_ID`) REFERENCES `inb201`.`Events_T` (`Event_ID`)
	ON UPDATE RESTRICT
	ON DELETE RESTRICT
)


