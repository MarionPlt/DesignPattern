using DesignPattern_TP.Manettes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_TP.Consoles
{
    public abstract class ConsoleDeJeu
    {
        protected string modele;
        protected string couleur;
        protected int annee;
        protected bool isBluetooth;

        protected ConsoleDeJeu(string modele, string couleur, int annee, bool isBluetooth)
        {
            this.modele = modele;
            this.couleur = couleur;
            this.annee = annee;
            this.isBluetooth = isBluetooth;
        }



        public abstract void descriptonConsole();
        public abstract void branchementConsole();
        public abstract Manette getManette();
    }
}
