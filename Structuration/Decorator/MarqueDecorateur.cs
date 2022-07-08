using System;

public class MarqueDecorateur : Decorateur
{
  public MarqueDecorateur(ComposantGraphiqueVehicule
    composant) : base(composant){}

  protected void afficheLogo()
  {
    Console.WriteLine("Logo de la marque");
  }

  public override void affiche()
  {
    base.affiche();
    this.afficheLogo();
  }
}
