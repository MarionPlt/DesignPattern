using System;

public class CertificatCession : Document
{
  public override void affiche()
  {
    Console.WriteLine(
      "Affiche le certificat de cession : " + contenu);
  }

  public override void imprime()
  {
    Console.WriteLine(
      "Imprime le certificat de cession : " + contenu);
  }
}
