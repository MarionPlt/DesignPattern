using System;

public class FormImmatriculationLuxembourg :
  FormulaireImmatriculation
{
  public FormImmatriculationLuxembourg(FormulaireImpl
    implantation) : base(implantation){}

  protected override bool controleSaisie(string plaque)
  {
    return plaque.Length == 5;
  }
}
