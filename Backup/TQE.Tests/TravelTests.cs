using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Travel;

namespace TQE.Tests
{
    [TestClass]
    public class TravelTests
    {
        private FakeDB _fakeDB;
        private QuoteEngineFactory _factory;
        private QuoteEngine _quoteEngine;

        public TravelTests()
        {
            _fakeDB = new FakeDB();
            _factory = new QuoteEngineFactory();
        }

        private TestContext testContextInstance;

        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        [TestMethod]
        public void TestBasePremium_SingleTrip()
        {
            Assert.AreEqual(20.00, _fakeDB.GetBasePremium(QuoteType.SingleTrip));
        }

        [TestMethod]
        public void TestBasePremium_AnnualTrip()
        {
            Assert.AreEqual(80.00, _fakeDB.GetBasePremium(QuoteType.AnnualTrip));
        }

        [TestMethod]
        public void TestAgeWeighting_Age15()
        {
            Assert.AreEqual(1.2, _fakeDB.GetAgeWeighting(15));
        }

        [TestMethod]
        public void TestAgeWeighting_Age30()
        {
            Assert.AreEqual(1.0, _fakeDB.GetAgeWeighting(30));
        }

        [TestMethod]
        public void TestAgeWeighting_Age56()
        {
            Assert.AreEqual(1.8, _fakeDB.GetAgeWeighting(56));
        }

        [TestMethod]
        public void TestAgeWeighting_Age70()
        {
            Assert.AreEqual(2.0, _fakeDB.GetAgeWeighting(70));
        }

        [TestMethod]
        public void TestAgeWeighting_Decline()
        {
            Assert.AreEqual(-1, _fakeDB.GetAgeWeighting(71));
        }

        [TestMethod]
        public void TestGenderWeighting_Male()
        {
            Assert.AreEqual(1.2, _fakeDB.GetGenderWeighting(Gender.Male));
        }

        [TestMethod]
        public void TestGenderWeighting_Female()
        {
            Assert.AreEqual(0.9, _fakeDB.GetGenderWeighting(Gender.Female));
        }

        [TestMethod]
        public void TestTripDurationWeighting_7Days()
        {
            Assert.AreEqual(0.5, _fakeDB.GetTripDurationWeighting(7));  
        }

        [TestMethod]
        public void TestTripDurationWeighting_14Days()
        {
            Assert.AreEqual(0.9, _fakeDB.GetTripDurationWeighting(14));
        }

        [TestMethod]
        public void TestTripDurationWeighting_21Days()
        {
            Assert.AreEqual(1.2, _fakeDB.GetTripDurationWeighting(21));
        }

        [TestMethod]
        public void TestTripDurationWeighting_30Days()
        {
            Assert.AreEqual(1.2, _fakeDB.GetTripDurationWeighting(30));
        }

        [TestMethod]
        public void TestTripDurationWeighting_Decline()
        {
            Assert.AreEqual(-1, _fakeDB.GetTripDurationWeighting(31));
        }

        [TestMethod]
        public void TestIPTValue()
        {
            Assert.AreEqual(1.05, _fakeDB.GetIPT());
        }

        [TestMethod]
        public void TestSample1ST()
        {
            string[] quoteInput = Helper.PrepareIt("Type:SingleTrip\nAge:20\nSex:Male\nDestination:UK\nPeriodOfTravel:10");

            SingleTripQuote STQ = new SingleTripQuote();

            STQ.Proposer.Age = Int32.Parse(quoteInput[1]);
            STQ.Proposer.Gender = (Gender)Enum.Parse(typeof(Gender), quoteInput[2]);
            STQ.Trip.Destination = (DestinationRegion)Enum.Parse(typeof(DestinationRegion), quoteInput[3]);
            STQ.Trip.PeriodOfTrip = Int32.Parse(quoteInput[4]);

            _quoteEngine = _factory.CreateQuoteEngine(STQ);
            _quoteEngine.CalculateQuote();

            Assert.AreEqual((float)13.608, (float)_quoteEngine.Premium);  
        }

        [TestMethod]
        public void TestSample2AT()
        {
            string[] quoteInput = Helper.PrepareIt("Type:AnnualTrip\nAge:67\nSex:Female\nDestination:Worldwide");

            AnnualTripQuote ATQ = new AnnualTripQuote();

            ATQ.Proposer.Age = Int32.Parse(quoteInput[1]);
            ATQ.Proposer.Gender = (Gender)Enum.Parse(typeof(Gender), quoteInput[2]);
            ATQ.Trip.Destination = (DestinationRegion)Enum.Parse(typeof(DestinationRegion), quoteInput[3]);

            _quoteEngine = _factory.CreateQuoteEngine(ATQ);
            _quoteEngine.CalculateQuote();

            Assert.AreEqual((float)211.68, (float)_quoteEngine.Premium);
        }

    }
}
