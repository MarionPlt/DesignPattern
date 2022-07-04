//abstract factory design pattern

//problématique : 
// a chaque fois qu'une nouvelle classe véhicule doit etre prise en compte, on doit modifier la classe mère
// l'abstract factory résoud les problemes de creation de classe dont on ne connait pas le contenu final
// afin de déresponsabiliser la classe mère

//ici utilisation d'une interface qui comprend la signature des méthodes qui permettront de construire chaque produit
//des sous classes fabriqueVehiculeElectrique et fabriqueVehiculeEssence
//def signature : son nom, ses entrées et ses sorties


//voir diagramme factory 
//partie scooter : classe abstraite Scooter, deux classes ScooterElectrique et ScooterEssence qui contiennent les parametres propres à chaque scooter

//Class catalogue