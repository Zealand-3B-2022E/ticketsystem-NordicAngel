using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSystemClassLibrary;

namespace TicketSystemClassLibTest
{
    [TestClass]
    public class TicketSystemVehicle
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void LicensplateLongerThan7exeptionTest()
        {
            //arrange
            new Car("12345678",DateTime.Now); //uses car which inherates relevent behavior from vehicle senese vehicle is abstract

            //assert
            Assert.Fail();
        }
    }
}
