using System;
using System.Text;
using System.Collections.Generic;
using System.Collections;

namespace Travel
{
    public abstract class QuoteEngine
    {
        public abstract void CalculateQuote();

        public double CalculatePremiumStep(double premium, double weighting)
        {
            return premium * weighting;
        }

        public double AdditionalCost()
        {
            return _premium - _previousPremium;
        }

        private TravelQuote _quote;
        private FakeDB _fakeDB = new FakeDB();
        private double _premium;
        private double _previousPremium;
        private PremiumBreakdownCollection _premiumBreakdown = new PremiumBreakdownCollection();

        public TravelQuote Quote
        {
            get { return _quote; }
            set { _quote = value; }
        }

        public double Premium
        {
            get { return _premium; }
            set { _premium = value; }
        }

        public double PreviousPremium
        {
            get { return _previousPremium; }
            set { _previousPremium = value; }
        }

        public double TotalPremium
        {
            get { return _premium; }
        }

        public PremiumBreakdownCollection PremiumBreakdowns 
        {
            get { return _premiumBreakdown; }
        }

        public FakeDB FakeDB
        {
            get { return _fakeDB; }
        }

        public string QuoteString()
        {
            StringBuilder output = new StringBuilder();

            foreach (PremiumBreakdown step in PremiumBreakdowns)
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
