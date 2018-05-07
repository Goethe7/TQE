namespace TQE.TravelQuote
{
    using TQE.Common;

    public class TravelQuote
    {
        public TravelQuote()
        {
            this.Proposer = new Proposer();
            this.Trip = new Trip();
        }

        public TravelQuote(int age, Gender gender, DestinationRegion region)
        {
            this.Proposer = new Proposer(age, gender);
            this.Trip = new Trip(region);
        }

        public TravelQuote(int age, Gender gender, DestinationRegion region, int period)
        {
            this.Proposer = new Proposer(age, gender);
            this.Trip = new Trip(region, period);
        }

        public Proposer Proposer { get; set; }

        public Trip Trip { get; set; }
    }
}
