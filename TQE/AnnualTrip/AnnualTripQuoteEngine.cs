namespace TQE.AnnualTrip
{
    using TQE.Common;
    using TQE.TravelQuote;

    class AnnualTripQuoteEngine : QuoteEngine
    {
        public AnnualTripQuoteEngine(TravelQuote travelQuote)
        {
            this.Quote = travelQuote;
        }

        public override void CalculateQuote()
        {
            this.Premium = this.FakeDb.GetBasePremium(QuoteType.AnnualTrip);
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
            this.Premium = this.CalculatePremiumStep(this.Premium, this.FakeDb.GetIPT());
            this.PremiumBreakdowns.Add(new PremiumBreakdown("Tax", this.AdditionalCost(), this.Premium));

        }
    }
}
