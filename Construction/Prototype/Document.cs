using System;

public abstract class Document
{
  protected string contenu = "";

  public Document duplique()
  {
    Document resultat;
    resultat = (Document)this.MemberwiseClone();
    return resultat;
  }

  public void remplit(string informations)
  {
    contenu = informations;
  }

  public abstract void imprime();
  public abstract void affiche();
}
