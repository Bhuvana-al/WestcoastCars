namespace Client.Models;

public class Engine
{
    public int HorsePower { get; set; }
    public double Volume { get; set; }
    public string? FuelType { get; set; }

    public override string ToString()
    {
        //return $"Hästkrafter: {HorsePower} - Volym: {Volume} - Bränsletyp: {FuelType}";
        return $"Bränsletyp: {FuelType}";
    }
}
