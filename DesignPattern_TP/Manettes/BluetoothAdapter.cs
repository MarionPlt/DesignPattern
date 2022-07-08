

namespace DesignPattern_TP.Manettes
{
    public class BluetoothAdapter : ManetteFilaire
    {
        public BluetoothAdapter(string couleurPrincipale) : base(couleurPrincipale)
        {
        }

        public bool connecterManette()
        {
            Console.WriteLine("Vous pouvez appairer la manette via le bluetooth grâce à un adapteur");
            return true;
        }
    }
}
