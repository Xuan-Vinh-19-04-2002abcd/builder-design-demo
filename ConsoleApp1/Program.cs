// See https://aka.ms/new-console-template for more information

using ConsoleApp1.BuilderPattern;

var carByBuilder = new CarBuilder()
    .AddWeels(4)
    .Paint("black")
    .AddNameCar("Felari")
    .Build();
Console.WriteLine(carByBuilder.ToString());
