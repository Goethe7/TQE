namespace Travel
{
    public class PremiumBreakdown
    {
        private string _description;
        private double _additionalCost;
        private double _premium;

        public PremiumBreakdown(string description, double additionalCost, double newPremium)
        {
            _description = description;
            _additionalCost = additionalCost;
            _premium = newPremium;
        }

        public string Description { get { return _description; } }
        public double AdditionalCost { get { return _additionalCost; } }
        public double Premium { get { return _premium; }  }

    }
}
