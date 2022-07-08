using System;

public class Marque : ObjetBase
{
  protected string description1, description2;
  protected string nom;

  public Marque(string nom, string description1, string
    description2)
  {
    this.description1 = description1;
    this.description2 = description2;
    this.nom = nom;
  }


  protected override string description
  {
   get
    {
      if ((description1 != null) && (description2 != null))
       return "Marque " + nom + " : " + description1 + " "
         + description2;
      else if (description1 != null)
       return "Marque " + nom + " : " + description1;
      else
       return null;
    }
  }
}
