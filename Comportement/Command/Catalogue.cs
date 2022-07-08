using System.Collections.Generic;

public class Catalogue
{
  protected IList<Vehicule> vehiculesStock = 
      new List<Vehicule>();
  protected IList<CommandeSolder> commandes =
      new List<CommandeSolder>();

  public void lanceCommandeSolder(CommandeSolder commande)
  {
    commandes.Insert(0, commande);
    commande.solde(vehiculesStock);
  }

  public void annuleCommandeSolder(int ordre)
  {
    commandes[ordre].annule();
  }

  public void retablitCommandeSolder(int ordre)
  {
    commandes[ordre].retablit();
  }

  public void ajoute(Vehicule vehicule)
  {
    vehiculesStock.Add(vehicule);
  }

  public void affiche()
  {
    foreach (Vehicule vehicule in vehiculesStock)
      vehicule.affiche();
  }
}
