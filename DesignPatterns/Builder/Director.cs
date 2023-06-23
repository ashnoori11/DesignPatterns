using DesignPatterns.Builder.Abstractions;


namespace DesignPatterns.Builder;

public class Director
{
    private CarBuilder carBuilder;

    public Director(CarBuilder builder)
    {
        carBuilder = builder;
    }

    public void ConstructCar()
    {
        carBuilder.CreateNewCar();
        carBuilder.AddSunroof();
        carBuilder.AddNavigationSystem();
        carBuilder.AddLeatherSeats();
    }
}
