using DesignPatterns.Builder.Models;

namespace DesignPatterns.Builder.Abstractions;

public abstract class CarBuilder
{
    protected Car car;

    public Car GetCar()
    {
        return car;
    }

    public void CreateNewCar()
    {
        car = new Car();
    }

    public abstract void AddSunroof();
    public abstract void AddNavigationSystem();
    public abstract void AddLeatherSeats();
}
