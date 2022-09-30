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
    }
}
