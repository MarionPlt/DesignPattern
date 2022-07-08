using System;

public interface Document
{
  string contenu { set; }
  void dessine();
  void imprime();
}
