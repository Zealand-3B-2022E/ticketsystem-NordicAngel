using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketSystemClassLibrary;

namespace TicketSystemClassLibTest
{
    [TestClass]
    public class TicketSystemMC
    {
        [TestMethod]
        public void MCPriceTest()
        {
            //arrange
            MC mc = new("9999999", DateTime.Now);

            //act
            double actual = mc.Price();

            //assert
            Assert.AreEqual(125, actual);
        }

        [TestMethod]
        public void MCVehicleTypeTest()
        {
            //arrange
            MC mc = new("9999999", DateTime.Now);

            //act
            string actual = mc.VehicleType();

            //assert
            Assert.AreEqual("MC", actual);
        }

        [TestMethod]
        public void MCBrobizzDiscount()
        {
            //arrange
            MC mc = new("9999999", DateTime.Now, true);

            //act
            double actual = mc.Price();

            //assert
            Assert.AreEqual(118.75, actual);
        }
    }
}
