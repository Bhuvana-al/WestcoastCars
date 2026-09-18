namespace Client.Models;

public class Engine
{
    public int HorsePower { get; set; }
    public double Volume { get; set; }
    public string? FuelType { get; set; }

    public override string ToString()
    {
        return $"HorsePower: {HorsePower} - Volume: {Volume} - FuelType: {FuelType}";
    }
}
