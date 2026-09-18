using System.Formats.Asn1;
using Client.Models;
namespace Client;

class Program
{
    //skapa en array som lagrar 3 stranger(tillverkare av bilar)
    static void Main()
    {
        //korrekt syntax for att instansiera ett objekt..
        //volvo ar ett objekt av typen vehicle...
        Vehicle volvo = new Vehicle(manufacturer:"Volvo", "EX30");

        //volvo.Manufacturer = "Volvo"; //Anrop sker nu till set i egenskapen
        //volvo.Model = "EX30";
        volvo.ModelYear = 2025;

        string model = volvo.Model; //anrop get
        Console.WriteLine(volvo.Manufacturer); //anrop get
        Console.WriteLine(volvo.Model); //Anrop get
        Console.WriteLine(volvo.ModelYear);

        Vehicle ford = new Vehicle("Ford", "Fusion");
        //ford.Manufacturer = "Ford";
        //ford.Model = "Fusion";
        ford.ModelYear = 2005;

        Console.WriteLine(ford.Manufacturer); //Anrop get
        Console.WriteLine(ford.Model); //Anrop get
        Console.WriteLine(ford.ModelYear);
    }
}
