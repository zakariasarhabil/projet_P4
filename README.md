

<br />
<p align="center">
  <a href="https://github.com/soukainaagdal/Environnement-News">
    
  </a>

  <h3 align="center">Project P4</h3>

  <p align="center">
   Environnement news site web
    <br />
    <a href="https://github.com/soukainaagdal/"><strong>view profile »</strong></a>
    <br />
    <br />
    <a href="https://github.com/soukainaagdal/Environnement-news">View Demo</a>
    ·
 
  </p>
</p>






* [PRÉSENTATION DU PROJET ](#PRÉSENTATION-DU-PROJET )
  * [Identification de besoin ](#Identification-de_besoin )
* [Description de l'existant ](#Description-de-l'existant )
  * [Definition du projet](#Definition-du-projet)
  * [OBJECTIFS](#OBJECTIFS)
  * [CARACTÉRISTIQUES](#CARACTÉRISTIQUES)
* [Diagrame](#diagrame)
  * [Diagramme de Use Case ](#Diagramme-de-Use-Case )
  * [Diagramme de séquence ](#Diagramme-de-séquence )
  * [Diagramme de classe ](#Diagramme-de-classe )
* [Les packages installés ](#Les-packages-installés )
* [Conception de Code ](#Conception-de-Code )
* [Les API à consommer ](#Les-API-à-consommer )
* [Contact](#contact)

## PRÉSENTATION DU PROJET

Youcode est une école de programmation qui ouvre les chances à tout le monde. C'est le rêve de tout débutant en codage et développement web, nouvellement créée à Youssoufia avec la collaboration du Groupe OCP et du leader français de l'éducation numérique (Simplon).

### Identification de besoin

Après la réunion avec M. Jaafar DAHBI (personnel de IT6 à Rabat), organisée dans le cadre de l'identification des problèmes confrontés par les gens intéressés par les nouveautés de la technologie et de l’informatique. À ce stade on a pu identifier les difficultés au niveau du nombre énorme des sites informatiques, et la nécessité d’une plateforme qui facilite l'accès aux nouveautés proposés par ces sites . 

## Description de l'existant

Si on prend par exemple le site web yahoo créé en 1999 constitué de plusieurs catégories et parmi ses catégories on trouve l'actualité informatique, la façon dont le site web est composé perturbe la bonne expérience de l’utilisateur par le nombre de rubriques et de pages proposés par le site et la façon de présentation des articles.




### Definition du projet

Dans le cadre du projet on est appelés à réaliser un projet pour la validation des compétences. 
La presse spécialisée regroupe l’ensemble des publications par opposition à la presse généraliste abordent un domaine particulier ou traite d’un thème précis. Comme techniques, sportifs, musicaux, littéraires ou scientifiques.

Dans notre cas en vas réaliser un projet de la presse thématique (Environnement news) 




### OBJECTIFS
 
1.	Création du Platform web d’actualités Environnement.
 
2.	Création d’une interface Admin (Dashboard) :

    a – La gestion des profils journaliste et rédacteur chef  et droit utilisateur.
    
    b – fonctionnalité CRUD (Modification, Supression,Consultation,Ajout).
    
    c - L’automatisation du système de notification .
    
 3. consommation des flux externe (rss , rest api ).
 
 
 ### CARACTÉRISTIQUES
 
- Un espace de blog ou d’actualités.
 
-	Un espace admin (Dashboard).

-	Un espace journaliste.

-	Un espace de rédacteur chef 

-	Consommer des API ou flux d’actualités.

-	Un Formulaire de contact.

-	Fonctionnalité de CRUD (Ajouter, Modifier, Supprimer, Consultation).

-	La météo.

-	Les publicités.

## Diagrame

- Conception de bases de données relationnelles avec UML. 

### Diagramme de Use Case 
![API page](https://github.com/soukainaagdal/ProjectP4/blob/master/useCase.png)

### Diagramme de séquence

![API page](https://github.com/soukainaagdal/ProjectP4/blob/master/seqeunce.PNG)


![API page](https://github.com/soukainaagdal/ProjectP4/blob/master/sqounce.PNG)

### Diagramme de classe

![API page](https://github.com/soukainaagdal/ProjectP4/blob/master/classe.PNG)



## Les packages installés

•	Microsoft.AspNet.WebApi.Cors

•	Microsoft.AspNet.Identity.Core

•	EntityFramework




## Conception de Code

Projet ASP.NET utilisant identité et entité Framework

Pour réalise nous projet en a divise la solution a 3 partie 

•	Partie RESTAPI tourisme qui contient des contrôleurs et des models.

•	Partie DATA sous forme d’une bibliothèque de classe qui contient un ADO lié avec notre base de données 

•	Partie LOGIQUE qui contient des traitements hors métiers.


## Les API à consommer





HOME:

### api/ Article /Article
•	Pour avoir liste des 10 Article dans body de  page Home  il faut utiliser le lien (get) : 

```sh
api/ Article /Article
```

Int ID , date date , string Titre ,string body , string img , string video ,string  NomJournaliste 


### api/ Article /Articleslide

Et pour avoir  3 article dans le slide odre par date il faut utiliser le lien (get) :

```sh
Api/article/Articleslide
```

Int ID , date date , string Titre ,string body , string img , string video ,string  NomJournaliste 














### api/ journalist / listJournalist

Pour avoir detaile de journaliste et les article ecrite il faut utiliser le lien (get)  avec id:

```sh
 api/ journalist /listJournalist
 ```
 
Int ID , string nom , string prenom ,string email , string tele, int nombrearticle , 



### api/ RedactionEnChef / RedactionEnChef

Pour avoir detaile de redaction en chef  il faut utiliser le lien (get)  avec id:

```sh
 api/ RedactionEnChef/ RedactionEnChef
 ```
 
Int ID , string nom , string prenom ,string email , string tele, int nombrearticle , 

### api/ RedactionEnChef / RedactionEnChefs
Pour avoir liste des redaction en chef evec les article ecrit utiliser le lien (get) :

```sh
api/redactionEnChef/ redactionEnChefs
```







