namespace TQE.FakeDB
{
    using System.Collections.Generic;
    using System.Linq;
    using TQE.Common;

    public class FakeDB
    {
        private readonly Dictionary<int, double> _tripDurationWeightings = new Dictionary<int, double>();
        private readonly Dictionary<int, double> _ageWeightings = new Dictionary<int, double>();

        public FakeDB()
        {
            // age weightings
            this._ageWeightings.Add(18, 1.2);
            this._ageWeightings.Add(45, 1.0);
            this._ageWeightings.Add(55, 1.2);
            this._ageWeightings.Add(65, 1.8);
            this._ageWeightings.Add(70, 2.0);

            // trip duration lookup
            this._tripDurationWeightings.Add(7, 0.5);
            this._tripDurationWeightings.Add(14, 0.9);
            this._tripDurationWeightings.Add(30, 1.2);

        }

        public double GetBasePremium(QuoteType quoteType)
        {
            double basePremium = 0;

            switch (quoteType)
            {
                case QuoteType.SingleTrip:
                    basePremium = 20.00;
                    break;
                case QuoteType.AnnualTrip:
                    basePremium = 80.00;
                    break;
            }

            return basePremium;
        }

        public double GetGenderWeighting(Gender gender)
        {
            return gender == Gender.Male ? 1.2 : 0.9;
        }

        public double GetAgeWeighting(int age)
        {
            try
            {
                return this._ageWeightings.First(p => p.Key >= age).Value;
            }
            catch
            {
                return -1;
            }
        }

        public double GetTripDestinationWeighting(DestinationRegion destination)
        {
            double destinationWeighting = 0;

            switch(destination)
            {
                case DestinationRegion.UK:
                    destinationWeighting = 0.6;
                    break;
                case DestinationRegion.Europe:
                    destinationWeighting = 1.0;
                    break;
                case DestinationRegion.Worldwide:
                    destinationWeighting = 1.4;
                    break;
            }

            return destinationWeighting;
        }

        public double GetTripDurationWeighting(int tripDuration)
        {
            try
            {
                return this._tripDurationWeightings.First(p => p.Key >= tripDuration).Value;
            }
            catch
            {
                return -1;
            }
        }

        public double GetIPT()
        {
            return 1.05;
        }

        public double AddIPT(double premium)
        {
            return premium * this.GetIPT();
        }
    }
}



