using System;

public class FormImmatriculationFrance :
  FormulaireImmatriculation
{
  public FormImmatriculationFrance(FormulaireImpl
    implantation) : base(implantation){}

  protected override bool controleSaisie(string plaque)
  {
    return plaque.Length == 7;
  }
}
