namespace TQE.Common
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
            this._destination = destination;
        }

        public Trip(DestinationRegion destination, int periodOfTrip) : this (destination)
        {
            this._periodOfTrip = periodOfTrip;
        }

        public DestinationRegion Destination
        {
            get { return this._destination; } 
            set { this._destination = value; } 
        }

        public int PeriodOfTrip
        {
            get { return this._periodOfTrip; }
            set { this._periodOfTrip = value; }            
        }
    }
}