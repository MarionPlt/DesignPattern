using System;

public abstract class FormulaireImmatriculation
{
  protected string contenu;
  protected FormulaireImpl implantation;

  public FormulaireImmatriculation(FormulaireImpl
    implantation)
  {
    this.implantation = implantation;
  }

  public void affiche()
  {
    implantation.dessineTexte(
      "numéro de la plaque existante : ");
  }

  public void genereDocument()
  {
    implantation.dessineTexte("Demande d'immatriculation");
    implantation.dessineTexte("numéro de plaque : " +
      contenu);
  }

  public bool gereSaisie()
  {
    contenu = implantation.gereZoneSaisie();
    return this.controleSaisie(contenu);
  }

  protected abstract bool controleSaisie(string plaque);
}
