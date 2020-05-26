
#Application d'export des données du serveur 10.192.20.30 :
-------------------
###Détails du projet :
------------------
- **Date de création** : 29/10/2019
- **Créateur** : Akhdari Zakaria
- **Superviseur** : Benchara Younes
- **Technologie** : .Net/C#
- **Type de projet** : Extraction depuis base de données
- **Fréquence d'exécution** : Quotidienne
- **Serveur d'exécution** : 10.122.20.51
- **Serveur de données** : 10.192.20.30
- **Serveur de configuration** : 10.122.20.51\SQLEXPRESS

###Description :
-----------
L'application permet de récupérer la totalité des informations de campagnes et les déposer dans un fichier par campagne.
En se basant sur la	table de configuration, nous récupérons les noms de campagnes, tables clients ainsi que tables d'appels, et ce afin de construire (en boucle) la requête de récupération des données.

L'objectif est de trouver le moyen le plus rapide (en temps de traitement), et qui peut gérer de grands volumes de données (plus de 50 000 lignes) en convertissant les données en CSV.

L'application devrait être capable d'être exécutée en tant que tâche planifiée (récupération des données du jour ), mais aussi de l'utiliser en mode récupération de données (possibilité de choisir la date et campagne à traîter).

###Informations techniques :
-------------------------

Ces informations sont à remplir à fur et à mesure de l'avancement du projet.
Merci de spécifier également tous les paramétrages effectués par le développeur lors de l'avancement sur le projet, ainsi que la configuration et modules supplémentaires.

####Format à utiliser :

- [DD/MM/YYYY HH:mm] [DEV FULLNAME] :	
  - "Configuration setting" == "Configuration value";

####Exemple :

- [29/10/2019 12:00] [Zakaria Akhdari] : 
  - "Version .net client" == "4.0";

###Historique :
-------------------------

Permet de donner un aperçu des grandes lignes du projet, tracer les évolutions majeurs et les noms de branches concernées.

####Format à utiliser :

- [DD/MM/YYYY HH:mm] [DEV FULLNAME] [Branch Name] :
  - "Title" == "Title of the changes"
  - "Description" == "A brieve description of the work done"

####Exemple :

- [29/10/2019 ] [Younes Benchara] [Master]:
  - "Title" == "Update README.md"
  - "Description" == "Updating the markdown in README.md file in order to have a proper display"

-------------
##ChangeLog :
-------------

###Informations techniques :
-------------------------

- [29/10/2019] [Zakaria Akhdari] : 
  - "Version .net client" == "4.0";


###Historique :
----------------------
- [28/10/2019] [Zakaria Akhdari] [Project_creation]:
  - "Title" == "Create project"
  - "Description" == "Creating the Form and it contians (CheckedListBox ,buttons ,DateTimePicker), Then connect the project to the database"
  
- [29/10/2019] [Younes Benchara] [Master]:
  - "Title" == "Update README.md"
  - "Description" == "Updatitng the README.md format to get an organized file"

- [30/10/2019] [Younes Benchara] [Master]:
  - "Title" == "Ignore files"
  - "Description" == "Add the bin/obj to .gitignore"

- [31/10/2019] [Zakaria Akhdari] [Project_creation]:
  - "Title" == "Connect to DataBase"
  - "Description" == "Create a Method to Connect to DataBase."

- [31/10/2019] [Zakaria Akhdari] [Project_creation]:
  - "Title" == "Retrieving Campaigns list"
  - "Description" == "Fill the CheckedListBox with campaign names. The CheckedListBox will be used to define which campaigns to extract data from."

- [01/10/2019] [Zakaria Akhdari] [Project_creation]:
  - "Title" == "Adding options to Campaign list"
  - "Description" == "Add selection options to he Campaign CheckedListBox => **Btn_Select_all** : Select all the compaign, **Btn_Unselect_all** : Select None and **Btn_Invert_Select** : Invert he selection"

- [02/11/2019] [Zakaria Akhdari] [Project_creation]:
  - "Title" == "Store the date in variable"
  - "Description" == "Storing the date in variable while the user change the date using the Event ValueChanged"
  - "Details" == "Change in order to get 20191104 instead of 2019114 , if the picked date is under 10 it should add a "0" behind the number ,
                 the same thing for the month , and store it in the varaible ExportDateString to use it somewhere ,
                 also you can't choose a date bigger than the actual date , or it will show an error message."

- [05/11/2019] [Zakaria Akhdari] [Project_creation]:
  - "Title" == "Exporting the data to CSV file"
  - "Description" == "Collect the informations from DataBase and store them in DataTable , and write the file name of CSV file."

- [31/11/2019] [Zakaria Akhdari] [Project_creation]:
  - "Title" == "Write to CSV"
  - "Description" == "Method write the informations into the file."