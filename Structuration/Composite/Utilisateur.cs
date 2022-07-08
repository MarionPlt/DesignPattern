using System;

public class Utilisateur
{
  static void Main(string[] args)
  {
    Societe societe1 = new SocieteSansFiliale();
    societe1.ajouteVehicule();
    Societe societe2 = new SocieteSansFiliale();
    societe2.ajouteVehicule();
    societe2.ajouteVehicule();
    Societe groupe = new SocieteMere();
    groupe.ajouteFiliale(societe1);
    groupe.ajouteFiliale(societe2);
    groupe.ajouteVehicule();
    Console.WriteLine(
      " Coût d'entretien total du groupe : " +
      groupe.calculeCoutEntretien());
  }
}
