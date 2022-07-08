using DesignPattern_TP.Manettes;

namespace DesignPattern_TP.Consoles
{
    public class ConsoleRF : ConsoleDeJeu
    {
        public ConsoleRF(string modele, string couleur, int annee, bool isBluetooth) : base(modele, couleur, annee, isBluetooth)
        {
        }

        public override void branchementConsole()
        {
            Console.WriteLine("Veuillez brancher la console à l'écran avec des cables Radio Fréquence");
        }

        public override void descriptonConsole()
        {
            Console.WriteLine("Votre console RF est connectée");
        }

        public override Manette getManette()
        {
            if (isBluetooth)
            {
                BluetoothAdapter adapter = new BluetoothAdapter(couleur);
                adapter.connecterManette();
                return new ManetteBluetooth(couleur);
            }
            else
            {
                ManetteFilaire manette = new ManetteFilaire(couleur);
                manette.connecterManette();
                return manette; 
            };
        }
    }
}
