using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OresundbroenTicketLibrary;

namespace TicketSystemClassLibTest
{
    [TestClass]
    public class OresundCar
    {
        [TestMethod]
        [DataRow(false, 410)]
        [DataRow(true, 161)]
        public void CarPrice(bool hasBrobizz, double expected)
        {
            //arrange
            Car car = new("9999999", DateTime.MinValue, hasBrobizz);

            //act
            double actual = car.Price();

            //assert
            Assert.AreEqual(expected,actual);
        }
    }
}
