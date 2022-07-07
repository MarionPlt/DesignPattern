using DesignPattern_TP.Consoles;

namespace DesignPattern_TP.Factories
{
    public class FactoryConsolePeritel : AbstractFactoryConsole
    {
       public  ConsoleDeJeu createConsoleDeJeu(string modele, string couleur, int annee, bool isBluetoothActivated)
        {
            return new ConsolePeritel(modele, couleur, annee, isBluetoothActivated);
        }
    }
}
