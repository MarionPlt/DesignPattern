using System;

public abstract class Controle
{
  public string valeur { get; protected set; }
  public Formulaire directeur { protected get;  set;}
  public string nom { get; protected set; }

  public Controle(string nom)
  {
    this.valeur = "";
    this.nom = nom;
  }

  public abstract void saisie();

  protected void modifie()
  {
    directeur.controleModifie(this);
  }
}
