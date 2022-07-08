

public class Ami : Aide

{
    private int aidePossible = 0;

    public override void aider(int nivAide) {
        if (nivAide == aidePossible) {
            Console.WriteLine( "je suis ton ami, je vais t'aider!");
        }
        else
        {
            Console.WriteLine("Ton ami ne peut pas t'aider, allons demander plus haut...");
            base.aider(nivAide);
        }
    }
    }
