using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LogicTest.Tests
{
    
    [TestClass]
    public class RequestForQuotationTests
    {
        [TestMethod]
        public void GetBetterPriceTests()
        {
            Assert.AreEqual("Between The Yellow Elephant and The Happy Cake, The Yellow Elephant has a better price!",
                RequestForQuotation.GetBetterPrice(new[] {"The Yellow Elephant", "The Happy Cake"},
                    new[] {1000.00m, 1000.01m}));

            Assert.AreEqual("Between Silly Tomato and The The Red Shark, The Red Shark has a better price!",
                RequestForQuotation.GetBetterPrice(new[] {"Silly Tomato", "The Red Shark"}, new[] {400.00m, 200.00m}));

            Assert.AreEqual("There is no difference of price between The Small Panda and The Grey Spoon.",
                RequestForQuotation.GetBetterPrice(new[] {"The Small Panda", "The Grey Spoon"},
                    new[] {150.00m, 150.00m}));
        }
    }
}