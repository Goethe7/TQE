namespace TQE.Common
{
    using System.Text;
    using TQE.FakeDB;
    using TQE.TravelQuote;

    public abstract class QuoteEngine
    {
        public abstract void CalculateQuote();

        public double CalculatePremiumStep(double premium, double weighting)
        {
            return premium * weighting;
        }

        public double AdditionalCost()
        {
            return this.Premium - this.PreviousPremium;
        }

        public TravelQuote Quote { get; set; }

        public double Premium { get; set; }

        public double PreviousPremium { get; set; }


        public PremiumBreakdownCollection PremiumBreakdowns { get; } = new PremiumBreakdownCollection();

        public FakeDB FakeDb { get; } = new FakeDB();

        public string QuoteString()
        {
            var output = new StringBuilder();

            foreach (var step in this.PremiumBreakdowns)
            {
                output.Append(step.Description);
                output.Append(" (" + step.AdditionalCost.ToString("C") + ") : ");
                output.Append(step.Premium.ToString("C"));
                output.Append("\n");
            }

            output.Append("Total Premium: ");
            output.Append(this.Premium.ToString("C"));
            output.Append("\n");

            return output.ToString();
        }
    }
}
