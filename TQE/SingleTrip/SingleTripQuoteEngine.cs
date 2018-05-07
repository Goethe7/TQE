namespace TQE.SingleTrip
{
    using TQE.Common;
    using TQE.TravelQuote;

    internal class SingleTripQuoteEngine : QuoteEngine
    {
        public SingleTripQuoteEngine(TravelQuote travelQuote)
        {
            this.Quote = travelQuote;
        }

        public override void CalculateQuote()
        {
           //var quote = (SingleTripQuote)this.Quote;  

           this.Premium = this.FakeDb.GetBasePremium(QuoteType.SingleTrip);
           this.PremiumBreakdowns.Add(new PremiumBreakdown("Base Premium", this.Premium, this.Premium));  

           this.PreviousPremium = this.Premium;
           this.Premium = this.CalculatePremiumStep(this.Premium, this.FakeDb.GetAgeWeighting(this.Quote.Proposer.Age));
           this.PremiumBreakdowns.Add(new PremiumBreakdown("Age", this.AdditionalCost(), this.Premium));  

           this.PreviousPremium = this.Premium;
           this.Premium = this.CalculatePremiumStep(this.Premium, this.FakeDb.GetGenderWeighting(this.Quote.Proposer.Gender));
           this.PremiumBreakdowns.Add(new PremiumBreakdown("Sex", this.AdditionalCost(), this.Premium));  

           this.PreviousPremium = this.Premium;
           this.Premium = this.CalculatePremiumStep(this.Premium, this.FakeDb.GetTripDestinationWeighting(this.Quote.Trip.Destination));
           this.PremiumBreakdowns.Add(new PremiumBreakdown("Destination", this.AdditionalCost(), this.Premium));  

           this.PreviousPremium = this.Premium;
           this.Premium = this.CalculatePremiumStep(this.Premium, this.FakeDb.GetTripDurationWeighting(this.Quote.Trip.PeriodOfTrip));
           this.PremiumBreakdowns.Add(new PremiumBreakdown("PeriodOfTravel", this.AdditionalCost(), this.Premium));

           this.PreviousPremium = this.Premium;
           this.Premium = this.CalculatePremiumStep(this.Premium, this.FakeDb.GetIPT());
           this.PremiumBreakdowns.Add(new PremiumBreakdown("Tax", this.AdditionalCost(), this.Premium));
                   
        }
    }
}

