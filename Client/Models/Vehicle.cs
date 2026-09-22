namespace Client.Models;

public class Vehicle(string manufacturer, string model)
{
    //skapa privata fält for tillverkare och modell

    //privata fälten (backing fields)
    //Detta är vårt data => information
    private string _manufacturer = manufacturer;
    private string _model = model;
    //private int _modelYear;

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

    //public int ModelYear
    //{
    //    get {return _modelYear;}
    //    set {_modelYear = value;}
    //}

    public override string ToString()
    {
       return $"Tillverkare: {Manufacturer} - Modell: {Model}";
    }
}
