using DesignPattern_TP.Consoles;

namespace DesignPattern_TP.Factories
{
    public class FactoryConsoleHDMI : AbstractFactoryConsole
    {
        public ConsoleDeJeu createConsoleDeJeu(string modele, string couleur, int annee, bool isBluetoothActivated)
        {
            return new ConsoleHDMI(modele, couleur, annee, isBluetoothActivated);
        }

        
    }
}
