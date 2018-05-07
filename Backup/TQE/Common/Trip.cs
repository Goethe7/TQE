namespace Travel
{
    public class Trip
    {
        private DestinationRegion _destination;
        private int _periodOfTrip;

        public Trip()
        {

        }

        public Trip(DestinationRegion destination)
        {
            _destination = destination;
        }

        public Trip(DestinationRegion destination, int periodOfTrip) : this (destination)
        {
            _periodOfTrip = periodOfTrip;
        }

        public DestinationRegion Destination
        {
            get { return _destination; } 
            set { _destination = value; } 
        }

        public int PeriodOfTrip
        {
            get { return _periodOfTrip; }
            set { _periodOfTrip = value; }            
        }
    }
}