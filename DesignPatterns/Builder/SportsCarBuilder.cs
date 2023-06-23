using DesignPatterns.Builder.Abstractions;
using DesignPatterns.Builder.Models;

namespace DesignPatterns.Builder;

public class SportsCarBuilder : CarBuilder
{
    public override void AddSunroof()
    {
        car.Sunroof = "Sunroof added";
    }

    public override void AddNavigationSystem()
    {
        car.NavigationSystem = "Navigation system added";
    }

    public override void AddLeatherSeats()
    {
        car.LeatherSeats = "Leather seats added";
    }
}
