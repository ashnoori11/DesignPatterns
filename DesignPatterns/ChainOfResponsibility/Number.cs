namespace DesignPatterns.ChainOfResponsibility;

public class Number
{
    private int _number;

    public Number(int number)
    {
        _number = number;
    }

    public int GetNumber()
    {
        return _number;
    }
}
