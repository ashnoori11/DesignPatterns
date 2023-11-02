using DesignPatterns.ChainOfResponsibility.Abstraction;

namespace DesignPatterns.ChainOfResponsibility;

public class Chain
{
    private Processor _chain;

    public Chain()
    {
        BuildChain();
    }

    private void BuildChain()
    {
        _chain = new NegativeProcessor(new ZeroProcessor(new PositiveProcessor(null)));
    }

    public void Process(Number request)
    {
        _chain.Process(request);
    }
}
