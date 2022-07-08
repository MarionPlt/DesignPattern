using System.Collections.Generic;

public class CommandeSolder
{
  protected IList<Vehicule> vehiculesSoldes =
      new List<Vehicule>();
  protected long aujourdhui;
  protected long dureeStock;
  protected double tauxRemise;

  public CommandeSolder(long aujourdhui, long dureeStock,
    double tauxRemise)
  {
    this.aujourdhui = aujourdhui;
    this.dureeStock = dureeStock;
    this.tauxRemise = tauxRemise;
  }

  public void solde(IList<Vehicule> vehicules)
  {
    vehiculesSoldes.Clear();
    foreach (Vehicule vehicule in vehicules)
      if (vehicule.getDureeStockage(aujourdhui) >=
        dureeStock)
        vehiculesSoldes.Add(vehicule);
    foreach (Vehicule vehicule in vehiculesSoldes)
      vehicule.modifiePrix(1.0 - tauxRemise);
  }

  public void annule()
  {
    foreach (Vehicule vehicule in vehiculesSoldes)
      vehicule.modifiePrix(1.0 / (1.0 - tauxRemise));
  }

  public void retablit()
  {
    foreach (Vehicule vehicule in vehiculesSoldes)
      vehicule.modifiePrix(1.0 - tauxRemise);
  }
}
