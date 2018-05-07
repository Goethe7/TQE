namespace TQE.Common
{
    public class PremiumBreakdown
    {
        private string _description;
        private double _additionalCost;
        private double _premium;

        public PremiumBreakdown(string description, double additionalCost, double newPremium)
        {
            this._description = description;
            this._additionalCost = additionalCost;
            this._premium = newPremium;
        }

        public string Description { get { return this._description; } }
        public double AdditionalCost { get { return this._additionalCost; } }
        public double Premium { get { return this._premium; }  }

    }
}
