using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_TP.Manettes
{
    internal class ManetteBluetooth : Manette
    {
        
        string couleurPrincipale;


        public ManetteBluetooth(string couleurPrincipale) : base(couleurPrincipale)
        {
        }

        public override bool connecterManette()
        {
            Console.WriteLine("Vous pouvez appairer la manette via le bluetooth");
            return true;
        }

        public override void descriptionManette()
        {
            Console.WriteLine("C'est une belle manette bluetooth " + couleurPrincipale + " ! ");
        }


    }
}
