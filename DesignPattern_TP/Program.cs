using DesignPattern_TP;

public class Programm
{

    static void Main(string[] args)
    {
        BuilderCadeauDeNoel builder = new BuilderCadeauDeNoel();
        bool again;

        Console.WriteLine("Bienvenue dans la boutique de consoles de jeu ! ");

        do
        {
            Console.WriteLine("Voici la liste des consoles disponibles :  ");
            Console.WriteLine("PS1,PS2,PS3,PS4,VIDEOPAC,ATARI,NES, MASTERSYSTEM,XBOX,SWITCH");
            Console.WriteLine("Veuillez saisir la console souhaitée : ");
            string choixConsole = Console.ReadLine();
            Console.WriteLine("Souhaitez-vous des manettes Bluetooh? OUI/NON ");
            string choixManette = Console.ReadLine();
            Console.WriteLine("Commande en cours de préparation...");

            builder.prepareLeCadeau(choixConsole, choixManette.Equals("OUI"));
            Console.WriteLine("Souhaitez-vous refaire une commande? OUI/NON ");
            string choixRefaireCommande = Console.ReadLine();
            again = choixRefaireCommande.Equals("OUI");


        } while (again);

        Console.WriteLine("Merci de votre visite!");


    }
}