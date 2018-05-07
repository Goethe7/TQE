namespace TQE.Common
{
    using System.Collections;
    using System.Collections.Generic;

    public class PremiumBreakdownCollection : IEnumerable<PremiumBreakdown>
    {
        private List<PremiumBreakdown> _premiumItems;

        public PremiumBreakdownCollection() { this._premiumItems = new List<PremiumBreakdown>(); }

        public void Add(PremiumBreakdown premiumItem)
        {
            this._premiumItems.Add(premiumItem);
        }

        IEnumerator<PremiumBreakdown> IEnumerable<PremiumBreakdown>.GetEnumerator()
        { return this._premiumItems.GetEnumerator(); }
        IEnumerator IEnumerable.GetEnumerator()
        { return this._premiumItems.GetEnumerator(); }

    }
}
