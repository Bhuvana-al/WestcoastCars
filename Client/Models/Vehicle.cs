namespace Client.Models;

public class Vehicle
{
    //skapa privata fält for tillverkare och modell

    //privata fälten (backing fields)
    //Detta är vårt data => information
    private string _manufacturer;
    private string _model;

    //Beteende => Logik, manipulera värt data => tillstånd
    //skapa egenskaper som laser och skriver varden till de privata falten
    public string Manufacturer
    { 
        //Läser värdet på det privata faltet..
        get {return _manufacturer;}
        //Skriva ett värdet till det privata faltet..
        set {_manufacturer = value;}
    }    
    public string Model
    {
        get {return _model;}
        set {_model = value;}
    }

}
