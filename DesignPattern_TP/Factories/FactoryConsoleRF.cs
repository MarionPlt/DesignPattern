using DesignPattern_TP.Consoles;


namespace DesignPattern_TP.Factories
{
    public class FactoryConsoleRF : AbstractFactoryConsole
    {
        public ConsoleDeJeu createConsoleDeJeu(string modele, string couleur, int annee, bool isBluetoothActivated)
        {
            return new ConsoleRF(modele, couleur, annee, isBluetoothActivated);
        }
    }
}
