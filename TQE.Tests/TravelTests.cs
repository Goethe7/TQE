using System;

namespace TQE.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using TQE.AnnualTrip;
    using TQE.Common;
    using TQE.FakeDB;
    using TQE.SingleTrip;

    [TestClass]
    public class TravelTests
    {
        private readonly FakeDB _fakeDB;
        private readonly QuoteEngineFactory _factory;
        private QuoteEngine _quoteEngine;

        public TravelTests()
        {
            _fakeDB = new FakeDB();
            _factory = new QuoteEngineFactory();
        }

        public TestContext TestContext { get; set; }

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
            var quoteInput = Helper.PrepareIt("Type:SingleTrip\nAge:20\nSex:Male\nDestination:UK\nPeriodOfTravel:10");

            var STQ = new SingleTripQuote
                          {
                              Proposer =
                                  {
                                      Age = int.Parse(quoteInput[1]),
                                      Gender = (Gender)Enum.Parse(typeof(Gender), quoteInput[2])
                                  },
                              Trip =
                                  {
                                      Destination = (DestinationRegion)Enum.Parse(typeof(DestinationRegion), quoteInput[3]),
                                      PeriodOfTrip = int.Parse(quoteInput[4])
                                  }
                          };


            _quoteEngine = _factory.CreateQuoteEngine(STQ);
            _quoteEngine.CalculateQuote();

            Assert.AreEqual((float)13.608, (float)_quoteEngine.Premium);  
        }

        [TestMethod]
        public void TestSample2AT()
        {
            var quoteInput = Helper.PrepareIt("Type:AnnualTrip\nAge:67\nSex:Female\nDestination:Worldwide");

            var ATQ = new AnnualTripQuote
                          {
                              Proposer =
                                  {
                                      Age = int.Parse(quoteInput[1]),
                                      Gender = (Gender)Enum.Parse(typeof(Gender), quoteInput[2])
                                  },
                              Trip =
                                  {
                                      Destination = (DestinationRegion)Enum.Parse(typeof(DestinationRegion), quoteInput[3])
                                  }
                          };


            _quoteEngine = _factory.CreateQuoteEngine(ATQ);
            _quoteEngine.CalculateQuote();

            Assert.AreEqual((float)211.68, (float)_quoteEngine.Premium);
        }

    }
}
