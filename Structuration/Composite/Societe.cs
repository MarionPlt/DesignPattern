using System;

public abstract class Societe
{
  protected static double coutUnitVehicule = 5.0;
  protected int nbrVehicules;

  public void ajouteVehicule()
  {
    nbrVehicules = nbrVehicules + 1;
  }

  public abstract double calculeCoutEntretien();

  public abstract bool ajouteFiliale(Societe filiale);
}
