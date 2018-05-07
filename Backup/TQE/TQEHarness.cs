using System;
using System.Windows.Forms;

namespace Travel
{
    public partial class TQEHarness : Form
    {
        private QuoteEngineFactory _factory = new QuoteEngineFactory();
        private QuoteEngine _quoteEngine;

        public TQEHarness()
        {
            InitializeComponent();
        }

        private void TQEHarness_Load(object sender, EventArgs e)
        {
        }

        private void butInput1_Click(object sender, EventArgs e)
        {
            DisplayQuoteInput("Type:SingleTrip\nAge:20\nSex:Male\nDestination:UK\nPeriodOfTravel:10");
        }

        private void butInput2_Click(object sender, EventArgs e)
        {
            DisplayQuoteInput("Type:AnnualTrip\nAge:67\nSex:Female\nDestination:Worldwide");
        }

        private void butInput3_Click(object sender, EventArgs e)
        {
            DisplayQuoteInput("Type:SingleTrip\nAge:76\nSex:Male\nDestination:Worldwide\nPeriodOfTravel:21");
        }

        private void DisplayQuoteInput(string input)
        {
            string[] quoteInput = input.Split('\n');
            txtInput.Lines = quoteInput;
            txtOutput.Text = "";
        }

        private void butQuoteNow_Click(object sender, EventArgs e)
        {
            string[] quoteInput = Helper.PrepareIt(txtInput.Text);

            if (quoteInput[0] == QuoteType.SingleTrip.ToString())
            {
                // just some simple validation for possible declines due to age or periodOfTravel risk
                if (ValidAge(Int32.Parse(quoteInput[1])))
                {
                    if (ValidPeriodOfTravel(Int32.Parse(quoteInput[4])))
                    {
                        SingleTripQuote STQ = new SingleTripQuote();

                        STQ.Proposer.Age = Int32.Parse(quoteInput[1]);
                        STQ.Proposer.Gender = (Gender)Enum.Parse(typeof(Gender), quoteInput[2]);
                        STQ.Trip.Destination = (DestinationRegion)Enum.Parse(typeof(DestinationRegion), quoteInput[3]);
                        STQ.Trip.PeriodOfTrip  = Int32.Parse(quoteInput[4]);

                        _quoteEngine = _factory.CreateQuoteEngine(STQ);
                        _quoteEngine.CalculateQuote();

                        DisplayQuote(_quoteEngine);
                    }
                    else
                    {
                        DeclineRequest("PeriodOfTravel");
                    }
                }
                else
                {
                    DeclineRequest("Age");
                }
            }

            if (quoteInput[0] == QuoteType.AnnualTrip.ToString())
            {
                // just some simple validation for possible decline due to age risk
                if (ValidAge(Int32.Parse(quoteInput[1])))
                {
                    AnnualTripQuote ATQ = new AnnualTripQuote();

                    ATQ.Proposer.Age = Int32.Parse(quoteInput[1]);
                    ATQ.Proposer.Gender = (Gender)Enum.Parse(typeof(Gender), quoteInput[2]);
                    ATQ.Trip.Destination = (DestinationRegion)Enum.Parse(typeof(DestinationRegion), quoteInput[3]);

                    _quoteEngine = _factory.CreateQuoteEngine(ATQ);
                    _quoteEngine.CalculateQuote();

                    DisplayQuote(_quoteEngine); 
                }
                else
                {
                    DeclineRequest("Age");
                }
            }
        
        }

        private bool ValidAge(int age)
        {
            return (age <= 70);
        }

        private bool ValidPeriodOfTravel(int duration)
        {
            return (duration <= 30);
        }

        private void DeclineRequest(string reason)
        {
            txtOutput.Text = "DECLINE: " + reason;
        }

        private void DisplayQuote(QuoteEngine qEngine)
        {
            string[] _quoteItems;

            _quoteItems = qEngine.QuoteString().Split('\n');
            txtOutput.Lines = _quoteItems; 
        }
    }
}
