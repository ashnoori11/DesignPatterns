namespace DesignPatterns.Singleton;

public class CurrencyConverter
{
    private static CurrencyConverter instance;
    private static readonly object lockObject = new object();

    private Dictionary<string, decimal> exchangeRates;

    // Private constructor to prevent instantiation outside the class
    private CurrencyConverter()
    {
        exchangeRates = new Dictionary<string, decimal>();
        exchangeRates.Add("USD", 1.0m); // Default exchange rate
    }

    public static CurrencyConverter Instance
    {
        get
        {
            if (instance is null)
                lock (lockObject)
                {
                    if (instance is null)
                        instance = new CurrencyConverter();
                }

            return instance;
        }
    }

    public void SetExchangeRate(string currencyCode, decimal rate)
    {
        if (exchangeRates.ContainsKey(currencyCode))
            exchangeRates[currencyCode] = rate;
        else
            exchangeRates.Add(currencyCode, rate);
    }

    public decimal ConvertCurrency(decimal amount, string fromCurrency, string toCurrency)
    {
        if (!exchangeRates.ContainsKey(fromCurrency) || !exchangeRates.ContainsKey(toCurrency))
            throw new ArgumentException("Invalid currency code.");

        decimal fromRate = exchangeRates[fromCurrency];
        decimal toRate = exchangeRates[toCurrency];

        decimal convertedAmount = amount * (toRate / fromRate);
        return convertedAmount;
    }
}
