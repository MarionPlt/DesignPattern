
namespace DesignPattern_TP
{
    public class Ecran
    {
        private string typeEcran;

        public Ecran(string typeEcran)
        {
            this.typeEcran = typeEcran;
        }

        public void descriptionEcran() {
            Console.WriteLine("Un écran "+ typeEcran+" est préparé");
        }



    }
}
