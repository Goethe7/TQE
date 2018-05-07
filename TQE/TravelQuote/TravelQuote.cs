namespace TQE.TravelQuote
{
    using TQE.Common;

    public class TravelQuote
    {
        private Proposer _proposer;
        private Trip _trip;

        public TravelQuote()
        {
            this._proposer = new Proposer();
            this._trip = new Trip();
        }

        public TravelQuote(int age, Gender gender, DestinationRegion region)
        {
            this._proposer = new Proposer(age, gender) ;
            this._trip = new Trip(region);
        }

        public TravelQuote(int age, Gender gender, DestinationRegion region, int period)
        {
            this._proposer = new Proposer(age, gender);
            this._trip = new Trip(region, period);
        }

        public Proposer Proposer
        {
            get { return this._proposer; }
            set { this._proposer = value; }
        }

        public Trip Trip
        {
            get { return this._trip; }
            set { this._trip = value; }
        }
        
    }
}
