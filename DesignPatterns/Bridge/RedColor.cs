using DesignPatterns.Bridge.Contracts;

namespace DesignPatterns.Bridge;

public class RedColor : IColor
{
    public void FillWithColor(int border)
    {
        Console.WriteLine($"Red color with {border} inch border");
    }
}
