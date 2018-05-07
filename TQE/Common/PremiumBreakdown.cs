namespace TQE.Common
{
    public class PremiumBreakdown
    {
        public PremiumBreakdown(string description, double additionalCost, double newPremium)
        {
            this.Description = description;
            this.AdditionalCost = additionalCost;
            this.Premium = newPremium;
        }

        public string Description { get; }

        public double AdditionalCost { get; }

        public double Premium { get; }
    }
}
