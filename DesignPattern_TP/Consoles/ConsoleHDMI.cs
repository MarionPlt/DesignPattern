using DesignPattern_TP.Manettes;


namespace DesignPattern_TP.Consoles
{
    public class ConsoleHDMI : ConsoleDeJeu
    {
        public ConsoleHDMI(string modele, string couleur, int annee, bool isBluetooth) : base(modele, couleur, annee, isBluetooth)
        {
        }

        public override void branchementConsole()
        {
            Console.WriteLine("Veuillez brancher la console à l'écran avec un cable HDMI");
        }

        public override void descriptonConsole()
        {
            Console.WriteLine("Votre console HDMI est connectée");
        }

        public override Manette getManette()
        {

            ManetteBluetooth manette = new ManetteBluetooth(couleur);
            manette.connecterManette();
            return manette;

        }
    }
}
