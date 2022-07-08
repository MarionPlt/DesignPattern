using System;

public class Utilisateur
{
  static void Main(string[] args)
  {
    Vehicule vehicule1 = new Vehicule("A01", 1, 1000.0);
    Vehicule vehicule2 = new Vehicule("A11", 6, 2000.0);
    Vehicule vehicule3 = new Vehicule("Z03", 2, 3000.0);
    Catalogue catalogue = new Catalogue();
    catalogue.ajoute(vehicule1);
    catalogue.ajoute(vehicule2);
    catalogue.ajoute(vehicule3);
    Console.WriteLine("Affichage du catalogue initial");
    catalogue.affiche();
    Console.WriteLine();
    CommandeSolder commmandeSolder = new CommandeSolder
      (10, 5, 0.1);
    catalogue.lanceCommandeSolder(commmandeSolder);
    Console.WriteLine("Affichage du catalogue après " + 
      "exécution de la première commande");
    catalogue.affiche();
    Console.WriteLine();
    CommandeSolder commmandeSolder2 = new CommandeSolder
      (10, 5, 0.5);
    catalogue.lanceCommandeSolder(commmandeSolder2);
    Console.WriteLine("Affichage du catalogue après " +
      "exécution de la seconde commande");
    catalogue.affiche();
    Console.WriteLine();
    catalogue.annuleCommandeSolder(1);
    Console.WriteLine("Affichage du catalogue après " +
      "annulation de la première commande");
    catalogue.affiche();
    Console.WriteLine();
    catalogue.retablitCommandeSolder(1);
    Console.WriteLine("Affichage du catalogue après " +
      "rétablissement de la première commande");
    catalogue.affiche();
    Console.WriteLine();
  }
}
