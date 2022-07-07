using DesignPattern_TP.Consoles;
using DesignPattern_TP.Factories;


namespace DesignPattern_TP
{
    public class BuilderCadeauDeNoel
    {
        AbstractFactoryConsole factoryConsole;
        ConsoleDeJeu console;
        Ecran ecran;

        public void prepareLeCadeau(string nomConsole, bool isManettesBluetooth)
        {
            switch (nomConsole)
            {
                case "PS1":
                    factoryConsole = new FactoryConsolePeritel();
                    console = factoryConsole.createConsoleDeJeu("PS1", "gris", 1994, isManettesBluetooth);
                    break;
                case "PS2":
                    factoryConsole = new FactoryConsolePeritel();
                    console = factoryConsole.createConsoleDeJeu("PS2", "noir", 2000, isManettesBluetooth);
                    break;
                case "PS3":
                    factoryConsole = new FactoryConsoleHDMI();
                    console = factoryConsole.createConsoleDeJeu("PS3", "noir", 2006, isManettesBluetooth);
                    break;
                case "PS4":
                    factoryConsole = new FactoryConsoleHDMI();
                    console = factoryConsole.createConsoleDeJeu("PS4", "noir", 2013, isManettesBluetooth);
                    break;
                case "VIDEOPAC":
                    factoryConsole = new FactoryConsoleRF();
                    console = factoryConsole.createConsoleDeJeu("Videopac", "gris", 1980, isManettesBluetooth);
                    break;
                case "ATARI":
                    factoryConsole = new FactoryConsoleRF();
                    console = factoryConsole.createConsoleDeJeu("Atari2600", "gris", 1981, isManettesBluetooth);
                    break;
                case "NES":
                    factoryConsole = new FactoryConsolePeritel();
                    console = factoryConsole.createConsoleDeJeu("NES", "gris", 1984, isManettesBluetooth);
                    break;
                case "MASTERSYSTEM":
                    factoryConsole = new FactoryConsolePeritel();
                    console = factoryConsole.createConsoleDeJeu("Mastersystem", "noir", 1985, isManettesBluetooth);
                    break;
                case "XBOX":
                    factoryConsole = new FactoryConsoleHDMI();
                    console = factoryConsole.createConsoleDeJeu("XboxserieX", "blanc", 2020, isManettesBluetooth);
                    break;
                case "SWITCH":
                    factoryConsole = new FactoryConsoleHDMI();
                    console = factoryConsole.createConsoleDeJeu("Switch", "bleu", 2017, isManettesBluetooth);

                    break;


            }
            console.descriptonConsole();
            console.branchementConsole();
            console.getManette();
            prepareEcran(console);
        }

        public void prepareEcran(ConsoleDeJeu console) {
                    switch (console.GetType().Name) {
                case "ConsoleHDMI":
                    ecran = new Ecran("plat");
                    ecran.descriptionEcran();
                    break;
                case "ConsolePeritel":
                    ecran = new Ecran("cathodique");
                    ecran.descriptionEcran();
                    break;
                case "ConsoleRF":
                    ecran = new Ecran("cathodique");
                    ecran.descriptionEcran();
                    break;
            };    


        }
    }
}
