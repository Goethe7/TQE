namespace TQE.Common
{
    using System.Text;
    using FakeDB;
    using TravelQuote;

    public abstract class QuoteEngine
    {
        public abstract void CalculateQuote();

        protected double CalculatePremiumStep(double premium, double weighting)
        {
            return premium * weighting;
        }

        protected double AdditionalCost()
        {
            return Premium - PreviousPremium;
        }

        protected TravelQuote Quote { get; set; }

        public double Premium { get; set; }

        protected double PreviousPremium { get; set; }


        protected PremiumBreakdownCollection PremiumBreakdowns { get; } = new PremiumBreakdownCollection();

        protected FakeDB FakeDb { get; } = new FakeDB();

        public string QuoteString()
        {
            var output = new StringBuilder();

            foreach (var step in PremiumBreakdowns)
            {
                output.Append(step.Description);
                output.Append(" (" + step.AdditionalCost.ToString("C") + ") : ");
                output.Append(step.Premium.ToString("C"));
                output.Append("\n");
            }

            output.Append("Total Premium: ");
            output.Append(Premium.ToString("C"));
            output.Append("\n");

            return output.ToString();
        }
    }
}
