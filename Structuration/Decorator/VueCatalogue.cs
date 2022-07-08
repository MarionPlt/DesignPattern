using System;

public class VueCatalogue
{
  static void Main(string[] args)
  {
    VueVehicule vueVehicule = new VueVehicule();
    ModeleDecorateur modeleDecorateur = new
      ModeleDecorateur(vueVehicule);
    MarqueDecorateur marqueDecorateur = new
      MarqueDecorateur(modeleDecorateur);
    marqueDecorateur.affiche();
  }
}
