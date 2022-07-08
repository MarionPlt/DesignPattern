using System;

public class DocumentHtml : Document
{
  protected string _contenu;

  public string contenu
  {
     protected get
     {
       return _contenu;
     }
     set
     {
       _contenu = value;
     }
  }

  public void dessine()
  {
    Console.WriteLine("Dessine document HTML : " +
      contenu);
  }

  public void imprime()
  {
    Console.WriteLine("Imprime document HTML : " +
      contenu);
  }

}
