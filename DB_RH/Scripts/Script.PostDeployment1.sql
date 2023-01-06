/*
Modèle de script de post-déploiement							
--------------------------------------------------------------------------------------
 Ce fichier contient des instructions SQL qui seront ajoutées au script de compilation.		
 Utilisez la syntaxe SQLCMD pour inclure un fichier dans le script de post-déploiement.			
 Exemple :      :r .\monfichier.sql								
 Utilisez la syntaxe SQLCMD pour référencer une variable dans le script de post-déploiement.		
 Exemple :      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/


INSERT INTO [Employes] (FirstName , LastName , DateDeNaissance , Fonction , NumeroTel , email) VALUES
('Nadine','Mirana','1993-04-05','Responsable qualité','045624256','Nadine12451@gmail.com'),
('Nassima','pakoki','1991-01-05','Responsable Des achats','04562425','Nassima12451@gmail.com'),
('Jean','nichola','1985-03-05','Directeur technique','045624258','Jean.nochla12451@gmail.com'),
('christophe','maroul','1997-01-05','developpeur .net','045624846','chris125@gmail.com')




INSERT INTO [Materials] (Brand,Type,RegistrationNumber,GrayCardNumber,ContractType,ContractName) VALUES
('Sulzer','Machine de tissage','A1D3R6F63G',1956328,'FreeContract','SulzerContract'),
('zalvor','Machine de filature','A1D3R6g23G',1954588,'Temporary20years','zalvorContract'),
('Aspirateur industriel ','Hygiene','B45566F63G',1956326,'FreeContract','R3589Contract')




