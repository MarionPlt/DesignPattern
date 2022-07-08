using System;

public class ZoneSaisie : Controle
{
  public ZoneSaisie(string nom) : base(nom){}

  public override void saisie()
  {
    Console.WriteLine("Saisie de : " + nom);
    valeur = Console.ReadLine();
    this.modifie();
  }
}
