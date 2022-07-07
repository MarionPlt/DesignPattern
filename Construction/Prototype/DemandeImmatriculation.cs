using System;

public class DemandeImmatriculation : Document
{
  public override void affiche()
  {
    Console.WriteLine(
      "Affiche la demande d'immatriculation : " + contenu);
  }

  public override void imprime()
  {
    Console.WriteLine(
      "Imprime la demande d'immatriculation : " + contenu);
  }
}
