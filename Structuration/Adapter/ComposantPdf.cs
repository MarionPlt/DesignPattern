using System;

public class ComposantPdf
{
  protected string contenu;

  public void pdfFixeContenu(string contenu)
  {
    this.contenu = contenu;
  }

  public void pdfPrepareAffichage()
  {
    Console.WriteLine("Affichage PDF : Début");
  }

  public void pdfRafraichit()
  {
    Console.WriteLine("Affichage contenu PDF : " +
      contenu);
  }

  public void pdfTermineAffichage()
  {
    Console.WriteLine("Affichage PDF : Fin");
  }

  public void pdfEnvoieImprimante()
  {
    Console.WriteLine("Impression PDF : " + contenu);
  }
}
