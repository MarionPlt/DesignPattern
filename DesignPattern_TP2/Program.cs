class Program {
    static void Main(string[] args) {
        //chain of responsability pour aider un Enfant.

        Enfant ambre = new Enfant();


        //description des personnes qui entourent l'enfant.

        Ami ami = new Ami();
        GrandeSoeur grandeSoeur = new GrandeSoeur();
        Parent parent = new Parent();
        ami.nextAide(grandeSoeur).nextAide(parent);


        //on met en place plusieurs scenarios où l'enfant va demander de l'aide, à différents niveaux dans la chaine de responsabilité
        Console.WriteLine("Ambre a besoin d'aide!");
        ambre.demanderDeLaide(ami, "j'ai perdu mes gommettes!", 0);

        Console.WriteLine("****************************************");

        Console.WriteLine("Ambre a besoin d'aide!");
        ambre.demanderDeLaide(grandeSoeur, "j'ai perdu mon doudou!", 2);
        Console.WriteLine("****************************************");

        Console.WriteLine("Ambre a besoin d'aide!");
        ambre.demanderDeLaide(ami, "Je n'arrive pas à attraper ma poupée!", 1);
        Console.WriteLine("****************************************");

        //on retrouve le comportement par défaut si le niveau d'aide est supérieur aux chaines de responsabilités programmées
        Console.WriteLine("Ambre a besoin d'aide!");
        ambre.demanderDeLaide(grandeSoeur, "Je suis perdue!", 5);





    }
}



