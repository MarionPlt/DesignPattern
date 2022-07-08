using System;

public class Enfant
{
	
    public  void demanderDeLaide(Aide aide, string demande, int nivAideDemandee) {
		Console.WriteLine(demande);
		 aide.aider(nivAideDemandee);
	}

	
}
