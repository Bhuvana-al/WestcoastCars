namespace Client.Models;

public class CarPark
{
    //skapa en autoimplementerad egenskap som hanterar en lista av klassen vehicle
    //Aggregation...
    public List<Vehicle> vehicles { get; set; } = [];

}
