/****** Script for SelectTopNRows command from SSMS  ******/
DROP TABLE IF EXISTS "Employe";

CREATE TABLE [dbo].[Employe] (
    [EmployeID]     INTEGER PRIMARY KEY NOT NULL IDENTITY(1,1),
    [Nom]           NVARCHAR (50)  NULL,
    [Prenom]        NVARCHAR (50)  NULL,
    [DateNaissance] DATETIME  NULL,
    [Adresse]       NVARCHAR (100) NULL,
    [Telephone]     NVARCHAR (50)  NULL,
    [Extension]     NVARCHAR (4)  NULL,
    [Courriel]      NVARCHAR (50)  NULL
);


INSERT INTO "Employe"("Nom","Prenom","DateNaissance","Adresse","Telephone","Extension","Courriel") VALUES('Davolio','Nancy','12/08/1948','507 - 20th Ave. E.Apt. 2A,WA,98122,USA','(206) 555-9857','5467','qwert@bell.ca');
INSERT INTO "Employe"("Nom","Prenom","DateNaissance","Adresse","Telephone","Extension","Courriel") VALUES('Fuller','Andrew','02/19/1952','908 W. Capital Way, WA, 98401, USA','(206) 555-9482','3457','aa.bb@videotron.ca');
INSERT INTO "Employe"("Nom","Prenom","DateNaissance","Adresse","Telephone","Extension","Courriel") VALUES('Leverling','Janet','08/30/1963','722 Moss Bay Blvd., WA, 98033,USA','(206) 555-3412','3355','xyz@outlook.com');
INSERT INTO "Employe"("Nom","Prenom","DateNaissance","Adresse","Telephone","Extension","Courriel") VALUES('Peacock','Margaret','09/19/1937','4110 Old Redmond Rd. , WA , 98052 , USA','(206) 555-8122','5176','qwert.azerty@france.telecom.ca');
INSERT INTO "Employe"("Nom","Prenom","DateNaissance","Adresse","Telephone","Extension","Courriel") VALUES('Buchanan','Steven','03/04/1955','14 Garrett Hill SW1 8JR , UK','(71) 555-4848','3453','qwert@verizon.ca');
INSERT INTO "Employe"("Nom","Prenom","DateNaissance","Adresse","Telephone","Extension","Courriel") VALUES('Suyama','Michael','07/02/1963','Coventry HouseMiner Rd. EC2 7JR , UK','(71) 555-7773','428','azerty@gmail.ca');

