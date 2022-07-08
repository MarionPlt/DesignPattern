using System;

public class ServeurWeb
{
  static void Main(string[] args)
  {
    Document document1, document2;
    document1 = new DocumentHtml();
    document1.contenu = "Hello";
    document1.dessine();
    Console.WriteLine();
    document2 = new DocumentPdf();
    document2.contenu = "Bonjour";
    document2.dessine();
  }
}
