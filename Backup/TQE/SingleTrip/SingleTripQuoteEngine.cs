namespace Travel
{
    class SingleTripQuoteEngine : QuoteEngine
    {
        public SingleTripQuoteEngine(TravelQuote travelQuote)
        {
            Quote = travelQuote;
        }

        public override void CalculateQuote()
        {
           SingleTripQuote quote = (SingleTripQuote)Quote;  

           Premium = FakeDB.GetBasePremium(QuoteType.SingleTrip);
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
           Premium = CalculatePremiumStep(Premium, FakeDB.GetTripDurationWeighting(Quote.Trip.PeriodOfTrip));
           PremiumBreakdowns.Add(new PremiumBreakdown("PeriodOfTravel", AdditionalCost(), Premium));

           PreviousPremium = Premium;
           Premium = CalculatePremiumStep(Premium, FakeDB.GetIPT());
           PremiumBreakdowns.Add(new PremiumBreakdown("Tax", AdditionalCost(), Premium));
                   
        }
    }
}

