namespace DesignPatterns.ChainOfResponsibility.Abstraction;

public abstract class Processor
{
    protected Processor _nextProcessor;

    public Processor(Processor nextProcessor)
    {
        _nextProcessor = nextProcessor;
    }

    public abstract void Process(Number request);
}
