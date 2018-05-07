namespace TQE.Common
{
    public class Trip
    {
        public Trip()
        {

        }

        public Trip(DestinationRegion destination)
        {
            this.Destination = destination;
        }

        public Trip(DestinationRegion destination, int periodOfTrip) : this(destination)
        {
            this.PeriodOfTrip = periodOfTrip;
        }

        public DestinationRegion Destination { get; set; }

        public int PeriodOfTrip { get; set; }
    }
}