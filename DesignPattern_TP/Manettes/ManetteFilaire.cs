

namespace DesignPattern_TP.Manettes
{
    public class ManetteFilaire : Manette
    {
       
        string couleurPrincipale;

        public ManetteFilaire( string couleurPrincipale) : base(couleurPrincipale) { }


        public override bool connecterManette()
        {
            Console.WriteLine("La manette doit être branchée à la console, vous ne pouvez pas utiliser le Bluetooth");
            return false;
        }

        public override void descriptionManette()
        {
            Console.WriteLine("C'est une belle manette filaire " + couleurPrincipale + "  ! ");
        }
    }
}
