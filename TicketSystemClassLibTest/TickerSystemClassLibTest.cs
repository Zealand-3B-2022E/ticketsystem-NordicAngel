using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketSystemClassLibrary;

namespace TicketSystemClassLibTest
{
    [TestClass]
    public class TickerSystemClassLibTest
    {
        [TestMethod]
        public void CarPriceTest()
        {
            //arrange
            Car car = new("999999", DateTime.Now);

            //act
            double actual = car.Price();

            //assert
            Assert.AreEqual(240, actual);
        }

        [TestMethod]
        public void CarVehicleTypeTest()
        {
            //arrange
            Car car = new("9999999", DateTime.Now);

            //act
            string actual = car.VehicleType();

            //assert
            Assert.AreEqual("Car", actual);
        }
    }
}