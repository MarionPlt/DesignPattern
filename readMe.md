#Marion PLAYOUT
**ESGI 4AL**

## Cours de Design Pattern
Le cours est découpé en trois grandes parties : 
 - pattern de construction
 - pattern destructuration
 - pattern de comportement

 Ces patterns résultent d'une utilisation en routine sur de gros projets. Ils permettent d'optimiser lors de montées en charge.
 
 ## TP de Design Pattern
 **But**  
 Implémenter une/plusieurs solutions avec au moins 3 Design Pattern. 

 ### 1) DesignPattern_TP  
 Une boutique de consoles de jeux permet de préparer les cadeaux pour les fêtes.
Pour que le client n'ait qu'un cadeau final devant ses yeux, un *builder* BuilderCadeauDeNoel se charger de préparer la commande.
Pour ce faire, le client doit répondre au clavier à deux questions :   
*1)donner le nom de la console*   
Le client doit saisir le nom de la console choisie en ligne de commande. Le client commande une ConsoleDeJeu, mais il ne sait pas par avance de quelle classe provient sa commande (ConsoleHDMI, ConsolePeritel ou ConsoleRF).
L'*abstract factory* permet de choisir le bon type de console. 
 
*2)le choix du type de manette*  
La technologie actuelle nous permet de jouer aux anciennes consoles avec des manettes plus récentes grâce à une classe *Adapter* BluetoothAdapter.

**TO DO** 
Lancer le programme avec la classe Program.cs


### 2) DesignPattern_TP2
Un enfant demanande de l'aide. Si la personne à qui iel s'adresse ne peut pas l'aider, la responsabilité est transférée au niveau de responsabilité supérieur grâce à un pattern *chain of responsability* .
On a une classe Enfant, et une classe abstraite Aide dont découle 3 classes de responsabilité Ami, GrandeSoeur et Parent. 
Selon le niveau d'aide demandé, la demande sera passée de classe en classe jusqu'à trouver le bon interlocuteur qui sera capable de traiter sa requete. 

**TO DO** 
Lancer le programme avec la classe Program.cs