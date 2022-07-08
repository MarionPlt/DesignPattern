using System;

public class Parent : Aide
{
    private int aidePossible = 2;
    public override void aider(int nivAide)
    {
        if (nivAide == aidePossible)
        {
            Console.WriteLine("je suis ton parent, je vais t'aider!");
        }
        else
        {
            Console.WriteLine("Ton parent ne peut pas t'aider, allons demander plus haut...");
             base.aider(nivAide);
        }
    }
}
