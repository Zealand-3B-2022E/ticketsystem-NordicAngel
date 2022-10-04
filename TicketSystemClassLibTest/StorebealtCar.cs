using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaeltTicketLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystemClassLibTest
{
    [TestClass]
    public class StorebealtCar
    {
        [TestMethod]
        [DataRow("2022/10/3 10:00:00", false, 240)] //monday
        [DataRow("2022/10/3 10:00:00", true, 228)] //monday
        [DataRow("2022/10/2 10:00:00", false, 192)] //sunday
        [DataRow("2022/10/2 10:00:00", true, 182.4)] //monday
        public void CarPrice(string date, bool brobizz, double expected)
        {
            //arrange
            Car car = new("9999999", DateTime.Parse(date), brobizz);

            //assert
            Assert.AreEqual(expected, car.Price(), 0.00000001);
        }
    }
}
