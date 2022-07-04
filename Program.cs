//abstract factory design pattern

//problématique : 
// a chaque fois qu'une nouvelle classe véhicule doit etre prise en compte, on doit modifier la classe mère
// l'abstract factory résoud les problemes de creation de classe dont on ne connait pas le contenu final
// afin de déresponsabiliser la classe mère

//ici utilisation d'une interface qui comprend la signature des méthodes qui permettront de construire chaque produit
//des sous classes fabriqueVehiculeElectrique et fabriqueVehiculeEssence
//def signature : son nom, ses entrées et ses sorties


//voir diagramme factory 
//partie scooter : classe abstraite Scooter, deux classes ScooterElectrique et ScooterEssence qui contiennent les parametres propres à chaque scooter

//Class catalogue
public abstract class Car {
    protected string model;
    protected string color;
    protected int power;
    protected double space;

    protected Car(string model, string color, int power, double space)
    {
        this.model = model;
        this.color = color;
        this.power = power;
        this.space = space;
    }

    public abstract void displayFeatures();
}

public class ElectricCar : Car
{
    public ElectricCar(string model, string color, int power, double space) : base(model, color, power, space)
    {
    }

    public override void displayFeatures()
    {
        Console.WriteLine("Electric car : ");
        Console.WriteLine("Model : "+model);
        Console.WriteLine("Color : "+color);
        Console.WriteLine("Power : "+power);
        Console.WriteLine("Space: "+space);
    }
}

public interface VehicleFactory {
    public Car buildCar(string model, string color, int power, double space);
    //can implement a second method buildScooter
}

public class ElectricVehicleFactory : VehicleFactory
{
    public Car buildCar(string model, string color, int power, double space)
    {
        return new ElectricCar(model, color, power, space);
    }

    //can implement a second method buildScooter that return an ElectricScooter
}


public class Catalogue {

    public static int vehicleNumber = 3;
    static void Main(string[] args) {
    VehicleFactory factory = new ElectricVehicleFactory();
        Car car = factory.buildCar("Tesla", "blue", 250, 2.5);
        car.displayFeatures();
    
    }
}