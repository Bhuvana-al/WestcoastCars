using System.Formats.Asn1;
using Client.Models;
namespace Client;

class Program
{
    //skapa en array som lagrar 3 stranger(tillverkare av bilar)
    static void Main()
    {
        CarPark carPark = new CarPark();

        Vehicle volvo = new Vehicle("Volvo", "XC60");
        var ford = new Vehicle("Ford", "Mustang MACH-E");
        Vehicle fiat = new("Fiat", "Uno");

        carPark.vehicles.Add(volvo);
        carPark.vehicles.Add(ford);
        carPark.vehicles.Add(fiat);

        foreach(var vehicle in carPark.vehicles)
        {
            //Console.WriteLine($"Tillverkare: {vehicle.Manufacturer} - Model: {vehicle.Model}");
            Console.WriteLine(vehicle.ToString());
            Console.WriteLine($"{vehicle} - Model år: {vehicle.ModelYear}");
        }
        /*
        //korrekt syntax for att instansiera ett objekt..
        //volvo ar ett objekt av typen vehicle...
        Vehicle volvo = new Vehicle(manufacturer: "Volvo", "EX30")
        {
            ModelYear = 2025
        };
        
        string model = volvo.Model; //anrop get
        Console.WriteLine(volvo.Manufacturer); //anrop get
        Console.WriteLine(volvo.Model); //Anrop get
        Console.WriteLine(volvo.ModelYear);

        Vehicle ford = new("Ford", "Fusion"); //Annat sätt att deklarera objekt
        //ford.Manufacturer = "Ford";
        //ford.Model = "Fusion";
        ford.ModelYear = 2005;

        Console.WriteLine(ford.Manufacturer); //Anrop get
        Console.WriteLine(ford.Model); //Anrop get
        Console.WriteLine(ford.ModelYear);
        */

    }
}
