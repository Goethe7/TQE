namespace TQE.SingleTrip
{
    using TQE.Common;
    using TQE.TravelQuote;

    class SingleTripQuoteEngine : QuoteEngine
    {
        public SingleTripQuoteEngine(TravelQuote travelQuote)
        {
            this.Quote = travelQuote;
        }

        public override void CalculateQuote()
        {
           SingleTripQuote quote = (SingleTripQuote)this.Quote;  

           this.Premium = this.FakeDB.GetBasePremium(QuoteType.SingleTrip);
           this.PremiumBreakdowns.Add(new PremiumBreakdown("Base Premium", this.Premium, this.Premium));  

           this.PreviousPremium = this.Premium;
           this.Premium = this.CalculatePremiumStep(this.Premium, this.FakeDB.GetAgeWeighting(this.Quote.Proposer.Age));
           this.PremiumBreakdowns.Add(new PremiumBreakdown("Age", this.AdditionalCost(), this.Premium));  

           this.PreviousPremium = this.Premium;
           this.Premium = this.CalculatePremiumStep(this.Premium, this.FakeDB.GetGenderWeighting(this.Quote.Proposer.Gender));
           this.PremiumBreakdowns.Add(new PremiumBreakdown("Sex", this.AdditionalCost(), this.Premium));  

           this.PreviousPremium = this.Premium;
           this.Premium = this.CalculatePremiumStep(this.Premium, this.FakeDB.GetTripDestinationWeighting(this.Quote.Trip.Destination));
           this.PremiumBreakdowns.Add(new PremiumBreakdown("Destination", this.AdditionalCost(), this.Premium));  

           this.PreviousPremium = this.Premium;
           this.Premium = this.CalculatePremiumStep(this.Premium, this.FakeDB.GetTripDurationWeighting(this.Quote.Trip.PeriodOfTrip));
           this.PremiumBreakdowns.Add(new PremiumBreakdown("PeriodOfTravel", this.AdditionalCost(), this.Premium));

           this.PreviousPremium = this.Premium;
           this.Premium = this.CalculatePremiumStep(this.Premium, this.FakeDB.GetIPT());
           this.PremiumBreakdowns.Add(new PremiumBreakdown("Tax", this.AdditionalCost(), this.Premium));
                   
        }
    }
}

