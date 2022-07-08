using System;
using System.Collections.Generic;

public abstract class Catalogue<TElement, TIterateur>
  where TElement : Element
  where TIterateur : Iterateur<TElement>, new()
{
  protected IList<TElement> contenu = 
      new List<TElement>();

  public TIterateur recherche(string motCleRequete)
  {
    TIterateur resultat = new TIterateur();
    resultat.motCleRequete = motCleRequete;
    resultat.contenu = contenu;
    return resultat;
  }
}
