# StiveAPI

API pour le projet de fin de formation POEC Développeur .NET.

(STIVE = STock, Inventaire et VEnte en ligne)


## Paramétrage de Git Bash

Dans le terminal Windows
- Définir un nom d'utilisateur : `git config --global user.name "Nom d'utilisateur"`
- Définir une adresse mail : `git config --global user.email adressemail@boitemail.fr`
- Définir la branche par défaut :  `git config --global init.defaultBranch main`
- Définir la méthode de "push" par défaut : `git config --global push.default current`


## Étape pour la mise en place du projet sur son ordinateur

1. Créer un nouveau projet Visual Studio de type `API web ASP.NET Core`

   Nom de projet : `StiveAPI`
2. Sur la page `Informations supplémentaires`, sélectionner `.NET 6.0`
3. `Créer` le projet
4. Dans le dossier du projet, aller dans le sous-dossier `StiveAPI`
5. Ouvrir le terminal dans ce dossier
   1. Clique droit dans le dossier
   2. Sélectionner `Ouvrir dans le Terminal`
6. Créer un répertoire vide avec la commande `git init`
7. Ajouter un lien entre ce dossier et GitHub

   `git remote add origin https://github.com/MathieuHeyk/StiveAPI.git`
8. Obtenir le code source du GitHub

   `git pull origin main`


## Ajouter une fonctionnalité

1. Créer une branche avec `git checkout -b utilitée_de_la_branche/nom_de_la_fonctionnalité`

   L'utilitée de la branche peut prendre plusieurs valeurs :
   - `feature` si l'objectif est d'ajouter une fonctionnalité
   - `bugfix` si l'objectif est de modifier un élément d'une fonctionnalité
2. Pour chaque modification :
   1. Lister les modifications apportées avec `git status`
   2. Ajouter les documents modifiés avec `git add .`
   3. Donner un libellé à l'ensemble des modifications

   `git commit -m "Description de la modification"`
   4. Mettre en ligne ses modifications avec `git push`


## Après avoir fini de créer une fonctionnalité

Quand tous les éléments d'une fonctionnalité ont été apportés :

1. Aller sur la page GitHub du projet
2. Aller dans l'onglet `Pull requests`
3. Changer la valeur `compare:` pour sélectionner la branche de la fonctionnalité
4. Cliquer sur `Create pull request`
5. Ajouter un libellé à la requête
   - Le libellé doit commencer par :
      - `[ADD]` s'il concerne l'ajout d'un élément
      - `[FIX]` s'il concerne la correction d'un élément
   - La suite du libellé contient une courte description de la fonctionnalité
6. Valider avec sélectionnant `Create pull request`