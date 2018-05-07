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
            return this._premium - this._previousPremium;
        }

        private TravelQuote _quote;
        private FakeDB _fakeDB = new FakeDB();
        private double _premium;
        private double _previousPremium;
        private PremiumBreakdownCollection _premiumBreakdown = new PremiumBreakdownCollection();

        public TravelQuote Quote
        {
            get { return this._quote; }
            set { this._quote = value; }
        }

        public double Premium
        {
            get { return this._premium; }
            set { this._premium = value; }
        }

        public double PreviousPremium
        {
            get { return this._previousPremium; }
            set { this._previousPremium = value; }
        }

        public double TotalPremium
        {
            get { return this._premium; }
        }

        public PremiumBreakdownCollection PremiumBreakdowns 
        {
            get { return this._premiumBreakdown; }
        }

        public FakeDB FakeDB
        {
            get { return this._fakeDB; }
        }

        public string QuoteString()
        {
            StringBuilder output = new StringBuilder();

            foreach (PremiumBreakdown step in this.PremiumBreakdowns)
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
