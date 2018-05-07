namespace Travel
{
    class AnnualTripQuoteEngine : QuoteEngine
    {
        public AnnualTripQuoteEngine(TravelQuote travelQuote)
        {
            Quote = travelQuote;
        }

        public override void CalculateQuote()
        {
            AnnualTripQuote quote = (AnnualTripQuote)Quote;

            Premium = FakeDB.GetBasePremium(QuoteType.AnnualTrip);
            PremiumBreakdowns.Add(new PremiumBreakdown("Base Premium", Premium, Premium));

            PreviousPremium = Premium;
            Premium = CalculatePremiumStep(Premium, FakeDB.GetAgeWeighting(Quote.Proposer.Age));
            PremiumBreakdowns.Add(new PremiumBreakdown("Age", AdditionalCost(), Premium));

            PreviousPremium = Premium;
            Premium = CalculatePremiumStep(Premium, FakeDB.GetGenderWeighting(Quote.Proposer.Gender));
            PremiumBreakdowns.Add(new PremiumBreakdown("Sex", AdditionalCost(), Premium));

            PreviousPremium = Premium;
            Premium = CalculatePremiumStep(Premium, FakeDB.GetTripDestinationWeighting(Quote.Trip.Destination));
            PremiumBreakdowns.Add(new PremiumBreakdown("Destination", AdditionalCost(), Premium));

            PreviousPremium = Premium;
            Premium = CalculatePremiumStep(Premium, FakeDB.GetIPT());
            PremiumBreakdowns.Add(new PremiumBreakdown("Tax", AdditionalCost(), Premium));

        }
    }
}
