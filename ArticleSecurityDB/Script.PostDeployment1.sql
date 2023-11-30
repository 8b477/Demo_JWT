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

INSERT INTO Article (Nom, Prix, Categorie, Description) VALUES ('Coca', 2, 'Boisson', 'Trop sucré')
INSERT INTO Article (Nom, Prix, Categorie, Description) VALUES ('Pepsi Max', 1, 'Boisson', 'Déjà mieux')
INSERT INTO Article (Nom, Prix, Categorie, Description) VALUES ('Mon pc', 1234, 'Hardware', 'Faut que je change')
