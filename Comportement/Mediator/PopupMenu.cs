using System;
using System.Collections.Generic;

public class PopupMenu : Controle
{
  protected IList<string> options = 
      new List<string>();

  public PopupMenu(string nom) : base(nom){}

  public override void saisie()
  {
    Console.WriteLine("Saisie de : " + nom);
    Console.WriteLine("Valeur actuelle : " + valeur);
    for (int index = 0; index < options.Count; index++)
      Console.WriteLine("- " + index + " )" +
        options[index]);
    int choix = int.Parse(Console.ReadLine());
    if ((choix >= 0) && (choix < options.Count))
    {
      bool change = (valeur != options[choix]);
      if (change)
      {
        valeur = options[choix];
        this.modifie();
      }
    }
  }

  public void ajouteOption(string option)
  {
    options.Add(option);
  }
}
