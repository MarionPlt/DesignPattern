


//classe abstraite Manette
namespace DesignPattern_TP.Manettes
{
    public abstract class Manette
    {

        protected string couleurPrincipale;

        protected Manette( string couleurPrincipale)
        {
            this.couleurPrincipale = couleurPrincipale;
        }

        public abstract bool connecterManette();
        public abstract void descriptionManette();

    }
}
