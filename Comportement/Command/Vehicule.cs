using System;

public class Vehicule
{
  protected string nom;
  protected long dateEntreeStock;
  protected double prixVente;

  public Vehicule(string nom, long dateEntreeStock,
    double prixVente)
  {
    this.nom = nom;
    this.dateEntreeStock = dateEntreeStock;
    this.prixVente = prixVente;
  }

  public long getDureeStockage(long aujourdhui)
  {
    return aujourdhui - dateEntreeStock;
  }

  public void modifiePrix(double coefficient)
  {
    this.prixVente = 0.01 * Math.Round(coefficient *
      this.prixVente * 100);
  }

  public void affiche()
  {
    Console.WriteLine(nom + " prix : " + prixVente + 
      " date entrée Stock " + dateEntreeStock);
  }
}
