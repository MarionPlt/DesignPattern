#Marion PLAYOUT
ESGI 4AL

## Cours de Design Pattern
Le cours est découpé en trois grandes parties : 
 - pattern de construction
 - pattern destructuration
 - pattern de comportement

 Ces patterns résultent d'une utilisation en routine sur de gros projets. Ils permettent d'optimiser lors de montées en charge.
 
 ## TP de Design Pattern
 **But**  
 Implémenter une/plusieurs solutions avec au moins 3 Design Pattern. 

 **Réalisé**  
 Une boutique de consoles de jeux permet de préparer les cadeaux pour les fêtes.
Pour que le client n'ait qu'un cadeau final devant ses yeux, un *builder* BuilderCadeauDeNoel se charger de préparer la commande.
Pour ce faire, le client doit répondre au clavier à deux questions :   
*1)donner le nom de la console*   
Le client doit saisir le nom de la console choisie en ligne de commande. Le client commande une ConsoleDeJeu, mais il ne sait pas par avance de quelle classe provient sa commande (ConsoleHDMI, ConsolePeritel ou ConsoleRF).
L'*abstract factory* permet de choisir le bon type de console. 
 
*2)le choix du type de manette*  
La technologie actuelle nous permet de jouer aux anciennes consoles avec des manettes plus récentes grâce à une classe *Adapter* BluetoothAdapter.




