# MvcDemoSept2015
Pour rejoindre le formateur: eric@coteexpert.com

##Modèle de données
Comment envoyer des données additionnelles qui ne sont pas dans le modèle? 2 façons: ViewModel ou ViewBag

###ViewModel
**Model**:  Modèle de données qui seront affichées par une vue
**ViewModel**: Modèle de donnéesqui est adapté pour une vue particulière 

###ViewBag
ViewData = ViewBag
Même données, mais une syntaxe différente.
     ViewData["Nom"]="Eric";
     ViewBag.Nom="Eric";

Le ViewBag permet de stocker des données qui peuvent être échangées entre un contrôleur et les vues. 

-------

##Usage du point d'interrogation en C#

###Nullable
    int? i;

###Opérateur ternaire (ternary)
    string x = condition==autre ? "oui" : "non"

###Opérateur Coalesce (élimine le null)
     string s = Nom ?? ""
     string s = Nom==null ? "" : Nom



####Opérateur Null conditionnel

    //Nouveau en C#6, Retourne null quand value est null, 
    // plutôt qu'une exception
    string value=null;
    string s = value?.Substring(0, Math.Min(value.Length, length));

    //la ligne suivante retourne un exception si value est null
    string s = value.Substring(0, Math.Min(value.Length, length));


##Communication SOA  (Service Oriented Architecture)
-  Découpler les services de l'entreprise en petits morceaux sur des serveurs séparés.  

**Avantages**
- séparer le couches sur différents serveurs, 
- permet une autonomie de services
- partionnement de la sécurité

**Inconvénients**
- plus long à coder
- plus complexe à écrire
- plus complexe à déboguer / diagnostiquer
- performances affectées
 
Voici différents Protocoles de communication
- web: Http, html
- Sqlserver: Socket tcp, TDS, SQL
- DCOM: Socket tcp 135,  COM  (1996)
- COM+: Socket tcp 135,  COM, (1999) Security, Message Queuing, Transactions, etc
  
- XML Web Services: Http, xml  (2001) (Sun, IBM, Oracle, Verisign)
- WS-*  (standards +- 2004) (Http, xml, Security, Message Queuing, Transactions)
- WSE  2004
- WCF  2006 (implémente 50% des spécifications)
  
- REST : Http, Verbes GET, POST, PUT, DELETE, Json 
          (Apple, Amazon, Twitter, facebook, Google, Microsoft,
           Platforme Smartphone)

**Http**   | **Sql**
=======|=====
GET    | SELECT
DELETE |  DELETE
PUT    |UPDATE
POST   | INSERT

Web API : Librairie REST/JSON de Microsoft 

Surtout utilisé par page web html5, smartphones et  App windows

Idempotent:  Le Post n'est pas Idempotent, ce qui signifie 
             que plusieurs appels auront des résultats Différents



##Injection SQL


    "SELECT * FROM LOGIN
     WHERE Nom=" + txtNom 
    "AND Pwd=" + txtPwd





