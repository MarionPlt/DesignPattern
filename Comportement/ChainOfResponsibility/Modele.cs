using System;

public class Modele : ObjetBase
{
  protected string laDescription;
  protected string nom;

  public Modele(string nom, string description)
  {
    this.laDescription = description;
    this.nom = nom;
  }

  protected override string description
  {
   get
    {
     if (laDescription != null)
      return "Modèle " + nom + " : " + laDescription;
     else
      return null;
    }
  }
}
