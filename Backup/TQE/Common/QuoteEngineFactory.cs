namespace Travel
{
    public class QuoteEngineFactory
    {
        public QuoteEngine CreateQuoteEngine(TravelQuote travelQuote)
        {
            QuoteEngine quoteEngine = null;

            if (travelQuote is SingleTripQuote)
            {
                quoteEngine = new SingleTripQuoteEngine(travelQuote);
            }
            else if (travelQuote is AnnualTripQuote)
            {
                quoteEngine = new AnnualTripQuoteEngine(travelQuote);
            }

            return quoteEngine;
        }
    }
}