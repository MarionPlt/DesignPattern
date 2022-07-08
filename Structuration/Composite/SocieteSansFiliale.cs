using System;

public class SocieteSansFiliale : Societe
{
  public override bool ajouteFiliale(Societe filiale)
  {
    return false;
  }

  public override double calculeCoutEntretien()
  {
    return nbrVehicules * coutUnitVehicule;
  }
}
