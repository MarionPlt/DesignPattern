using System;

public class GrandeSoeur : Aide

{
    private int aidePossible = 1;

    public override void aider(int nivAide)
    {
        if (nivAide == aidePossible)
        {
            Console.WriteLine( "je suis ta grande soeur, je vais t'aider!");
        }
        else
        {
            Console.WriteLine("Ta grande soeur ne peut pas t'aider, allons demander plus haut...");
            base.aider(nivAide);
        }
    }
}
