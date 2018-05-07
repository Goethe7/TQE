using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Travel
{
    public class TravelQuote
    {
        private Proposer _proposer;
        private Trip _trip;

        public TravelQuote()
        {
            _proposer = new Proposer();
            _trip = new Trip();
        }

        public TravelQuote(int age, Gender gender, DestinationRegion region)
        {
            _proposer = new Proposer(age, gender) ;
            _trip = new Trip(region);
        }

        public TravelQuote(int age, Gender gender, DestinationRegion region, int period)
        {
            _proposer = new Proposer(age, gender);
            _trip = new Trip(region, period);
        }

        public Proposer Proposer
        {
            get { return _proposer; }
            set { _proposer = value; }
        }

        public Trip Trip
        {
            get { return _trip; }
            set { _trip = value; }
        }
        
    }
}
