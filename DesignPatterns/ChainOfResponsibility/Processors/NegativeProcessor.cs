using DesignPatterns.ChainOfResponsibility.Abstraction;

namespace DesignPatterns.ChainOfResponsibility.Processors;

public class NegativeProcessor : Processor
{
    public NegativeProcessor(Processor nextProcessor) : base(nextProcessor)
    { }

    public override void Process(Number request)
    {
        if (request.GetNumber() < 0)
            Console.WriteLine($"NegativeProcessor : {request.GetNumber()}");
        else
            _nextProcessor?.Process(request);
    }
}
