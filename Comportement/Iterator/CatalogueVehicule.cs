public class CatalogueVehicule : Catalogue<Vehicule,
  IterateurVehicule> 
{

  public CatalogueVehicule()
  {
    contenu.Add(new Vehicule("véhicule bon marché"));
    contenu.Add(new Vehicule("petit véhicule bon marché"));
    contenu.Add(new Vehicule("véhicule grande qualité"));
  }
}
