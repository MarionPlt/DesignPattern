
using DesignPattern_TP.Consoles;

namespace DesignPattern_TP.Factories
{
    public interface AbstractFactoryConsole
    {
        public ConsoleDeJeu createConsoleDeJeu(string modele, string couleur, int annee, bool isBluetoothActivated);
    }
}
