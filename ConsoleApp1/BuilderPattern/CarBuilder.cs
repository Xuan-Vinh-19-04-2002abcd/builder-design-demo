namespace ConsoleApp1.BuilderPattern;

public class CarBuilder : ICarBuilder
{
    public int NumberOfWheels { get; set; }
    public string Color { get; set; }
    public string NameCar { get; set; }
    public CarBuilder AddWeels(int numberOfWheels)
    {
        NumberOfWheels = numberOfWheels;
        return this;
    }
    public CarBuilder Paint(string color)
    {
        Color = color;
        return this;
    }
    public CarBuilder AddNameCar(string nameCar)
    {
        NameCar = nameCar;
        return this;
    }
    public Car Build()
    {   
        return new Car(NumberOfWheels,Color,NameCar);
    }
}