using System.Collections;
using System.Collections.Generic;

namespace Travel
{
    public class PremiumBreakdownCollection : IEnumerable<PremiumBreakdown>
    {
        private List<PremiumBreakdown> _premiumItems;

        public PremiumBreakdownCollection() { _premiumItems = new List<PremiumBreakdown>(); }

        public void Add(PremiumBreakdown premiumItem)
        {
            _premiumItems.Add(premiumItem);
        }

        IEnumerator<PremiumBreakdown> IEnumerable<PremiumBreakdown>.GetEnumerator()
        { return _premiumItems.GetEnumerator(); }
        IEnumerator IEnumerable.GetEnumerator()
        { return _premiumItems.GetEnumerator(); }

    }
}
