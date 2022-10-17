using TaxAPI;

namespace UnitTests.EntityTests
{
    [TestClass]
    public class TaxTests
    {
        [TestMethod]
        public void TestProperties()
        {
            //Arrange & Act
            var entity = new Tax
            {
                InterestRate = 0.01
            };

            //Assert
            Assert.AreEqual(0.01, entity.InterestRate);
        }
    }
}
