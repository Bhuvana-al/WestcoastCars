namespace Client;

class Program
{
    //skapa en array som lagrar 3 stranger(tillverkare av bilar)
    static void Main()
    {
        //string[] vehicles = ["Volvo", "Ford", "Fiat"];
        List<string> vehicles = ["Volvo", "Ford", "Fiat"];

        Console.WriteLine(vehicles[1]);
        // Andra Ford till Volkswagen
        vehicles[1] = "Volkswagen";
        Console.WriteLine(vehicles[1]);
        //for is better than foreach
        /*for (int i=0; i < vehicles.Length; i++) //string[]
        {
            Console.WriteLine(vehicles[i]);
        } */
        for (int i=0; i < vehicles.Count; i++) //List
        {
            Console.WriteLine(vehicles[i]);
        }
        vehicles.Add("Mercedes");
        foreach(var vehicle in vehicles)
        {
            Console.WriteLine(vehicle);
        }
    }
}
