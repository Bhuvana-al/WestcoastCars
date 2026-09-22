namespace Client.Models;

public class Bike (string make, string model) : Vehicle(make, model)
{
    public int ModelYear {get; set;}
    public string? CycleType {get; set; }
    public string? WheelSize {get; set;}
    public int NumberOfGears {get; set;}

    public override string ToString()
    {
        return $"Tillverkare: {Manufacturer} - Modell: {Model} - Årsmodell: {ModelYear} - Cykeltyp: {CycleType} - Hjulstorlek: {WheelSize} - Antal växlar: {NumberOfGears}";
    }
    
}
