namespace ConsoleApp1.BuilderPattern;

public class Car
{
    public int NumberOfWheels { get; set; }
    public string Color { get; set; }
    public string NameCar { get; set; }

    public Car(int numberOfWheels, string color, string nameCar)
    {
        NumberOfWheels = numberOfWheels;
        Color = color;
        NameCar = nameCar;
    }
    public override string ToString()
    {
        var content = "";
        content += $"Number of wheels:    \t {NumberOfWheels}\n";
        content += $"Color:               \t {Color}\n";
        content += $"Name:               \t {NameCar}\n";
        return content;
    }   
}