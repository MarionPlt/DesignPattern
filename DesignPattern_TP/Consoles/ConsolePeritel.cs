using DesignPattern_TP.Manettes;


namespace DesignPattern_TP.Consoles
{
    public class ConsolePeritel : ConsoleDeJeu
    {
        public ConsolePeritel(string modele, string couleur, int annee, bool isBluetooth) : base(modele, couleur, annee, isBluetooth)
        {
        }

        public override void branchementConsole()
        {
            Console.WriteLine("Veuillez brancher la console à l'écran avec un cable Péritel");
        }

        public override void descriptonConsole()
        {
            Console.WriteLine("Votre console Péritel est connectée");
        }

        public override Manette getManette()
        {
            if (isBluetooth)
            {
                BluetoothAdapter adapter = new BluetoothAdapter();
                adapter.connecterManette();
                return new ManetteBluetooth( couleur);
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
