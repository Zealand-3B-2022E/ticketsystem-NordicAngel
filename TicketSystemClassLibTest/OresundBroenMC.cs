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
    public class OresundMC
    {
        [TestMethod]
        [DataRow(false, 210)]
        [DataRow(true, 73)]
        public void MCPrice(bool hasBrobizz, double expected)
        {
            //arrange
            MC mc = new("9999999", DateTime.MinValue, hasBrobizz);

            //act
            double actual = mc.Price();

            //assert
            Assert.AreEqual(expected,actual);
        }
    }
}
