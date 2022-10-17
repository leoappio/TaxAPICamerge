using TaxAPI;
using TaxAPI.Controllers;

namespace UnitTests.ControllersTests
{
    [TestClass]
    public class TaxControllerTests
    {
        [TestMethod]
        public void GettingInterestRateShouldReturnCorrectTaxObject()
        {
            //Arrange
            var controller = new TaxController();
            var expectedResult = new Tax
            {
                InterestRate = 0.01
            };

            //Act
            var result = controller.GetInterestRate();

            //Assert
            Assert.AreEqual(expectedResult.InterestRate, result.InterestRate);
        }
    }
}
