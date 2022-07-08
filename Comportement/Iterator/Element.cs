using System;

public abstract class Element
{
  protected string description;

  public Element(string description)
  {
    this.description = description;
  }

  public bool motCleValide(string motCle)
  {
    return description.IndexOf(motCle) !=  -1;
  }
}
