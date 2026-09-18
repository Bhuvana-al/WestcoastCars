using Client.Models;
namespace Client;

class Program
{
    //skapa en array som lagrar 3 stranger(tillverkare av bilar)
    static void Main()
    {
        //korrekt syntax for att instansiera ett objekt..
        //volvo ar ett objekt av typen vehicle...
        Vehicle volvo = new Vehicle();

        volvo.Manufacturer = "Volvo"; //Anrop sker nu till set i egenskapen
        volvo.Model = "EX30";

        string model = volvo.Model; //anrop get
        Console.WriteLine(volvo.Manufacturer); 
        Console.WriteLine(volvo.Model); 

        Vehicle x = new Vehicle();
        x.Manufacturer = "Ford";
        x.Model = "Fusion";

        Console.WriteLine(x.Manufacturer);
        Console.WriteLine(x.Model);
    }
}
