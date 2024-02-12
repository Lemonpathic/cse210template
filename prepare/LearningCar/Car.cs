namespace learningCar;

public class Car
{
    private string make;
    private string model;
    public int year { get; set; }

    public string GetMake()
    {
        return make;
    }

    public void SetMake(string newMake)
    {
        make = newMake;
    }
    public Car(string make, string model)
    {
        this.make = make;
        this.model = model;
    }
    
    public void PrintDetails()
    {
        Console.WriteLine($"{make}, {model}");
    }
}