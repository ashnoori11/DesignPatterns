using DesignPatterns.Bridge.Contracts;

namespace DesignPatterns.Bridge;

public class GreenColor : IColor
{
    public void FillWithColor(int border)
    {
        Console.WriteLine($"Green color with {border} inch border");
    }
}
