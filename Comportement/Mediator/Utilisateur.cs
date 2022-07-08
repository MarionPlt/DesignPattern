public class Utilisateur
{
  static void Main(string[] args)
  {
    Formulaire formulaire = new Formulaire();
    formulaire.ajouteControle(new ZoneSaisie("Nom"));
    formulaire.ajouteControle(new ZoneSaisie("Prénom"));
    PopupMenu menu = new PopupMenu("Coemprunteur");
    menu.ajouteOption("sans coemprunteur");
    menu.ajouteOption("avec coemprunteur");
    formulaire.ajouteControle(menu);
    formulaire.menuCoemprunteur = menu;
    Bouton bouton = new Bouton("OK");
    formulaire.ajouteControle(bouton);
    formulaire.boutonOK = bouton;
    formulaire.ajouteControleCoemprunteur(new ZoneSaisie(
      "Nom du coemprunteur"));
    formulaire.ajouteControleCoemprunteur(new ZoneSaisie(
      "Prénom du coemprunteur"));
    formulaire.saisie();
  }
}
