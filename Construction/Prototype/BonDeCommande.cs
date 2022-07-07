using System;

public class BonDeCommande : Document
{
  public override void affiche()
  {
    Console.WriteLine("Affiche le bon de commande : " +
      contenu);
  }

  public override void imprime()
  {
    Console.WriteLine("Imprime le bon de commande : " +
      contenu);
  }
}
