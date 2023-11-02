using DesignPatterns.ChainOfResponsibility.Abstraction;

namespace DesignPatterns.ChainOfResponsibility.Processors;

public class ZeroProcessor : Processor
{
    public ZeroProcessor(Processor nextProcessor) : base(nextProcessor)
    { }

    public override void Process(Number request)
    {
        if (request.GetNumber() == 0)
            Console.WriteLine($"ZeroProcessor : {request.GetNumber()}");
        else
            _nextProcessor?.Process(request);
    }
}
