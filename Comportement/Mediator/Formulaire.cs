using System.Collections.Generic;
using System;

public class Formulaire
{
  protected IList<Controle> controles = 
    new List<Controle>();
  protected IList<Controle> controlesCoemprunteur =
    new List<Controle>();
  public PopupMenu menuCoemprunteur { protected get; set; }
  public Bouton boutonOK { protected get; set; }
  protected bool enCours = true;

  public void ajouteControle(Controle controle)
  {
    controles.Add(controle);
    controle.directeur = this;
  }

  public void ajouteControleCoemprunteur(Controle
    controle)
  {
    controlesCoemprunteur.Add(controle);
    controle.directeur = this;
  }

  public void controleModifie(Controle controle)
  {
    if (controle == menuCoemprunteur) 
     if (controle.valeur == "avec coemprunteur")
      {
        foreach (Controle elementCoemprunteur in
         controlesCoemprunteur)
         elementCoemprunteur.saisie();
      }
    if (controle == boutonOK)
    {
      enCours = false;
    }
  }

  public void saisie()
  {
    while (true)
    {
      foreach (Controle controle in controles)
      {
        controle.saisie();
        if (!enCours)
          return ;
      }
    }
  }

}
