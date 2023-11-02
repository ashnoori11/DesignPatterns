using DesignPatterns.ChainOfResponsibility.Abstraction;

namespace DesignPatterns.ChainOfResponsibility.Processors;

public class PositiveProcessor : Processor
{
    public PositiveProcessor(Processor nextProcessor) : base(nextProcessor)
    { }

    public override void Process(Number request)
    {
        if (request.GetNumber() > 0)
            Console.WriteLine($"PositiveProcessor : {request.GetNumber()}");
        else
            _nextProcessor?.Process(request);
    }
}
