using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaeltTicketLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSystemClassLibrary;
using api = SortrebealtAPI.Managers.TicketManeger;
using Car = StoreBaeltTicketLibrary.Car;

namespace TicketSystemClassLibTest
{
    [TestClass]
    public class StorebealtAPITest
    {
        [TestMethod]
        public void CreateCarTest()
        {
            //arrange
            api.Tickets = new List<TicketSystemClassLibrary.Vehicle>();

            //act
            api.Create(new Car("9999999", DateTime.MinValue));

            //assert
            Assert.AreEqual(1, api.Tickets.Count);
        }

        [TestMethod]
        public void CreateMCTest()
        {
            //arrange
            api.Tickets = new List<Vehicle>();

            //act
            api.Create(new MC("9999999", DateTime.MinValue));

            //assert
            Assert.AreEqual(1, api.Tickets.Count);
        }

        [TestMethod]
        public void GetAllTest()
        {
            //arrange
            api.Tickets = new List<Vehicle>()
            {
                new MC("0000000", DateTime.MinValue),
                new MC("1111111", DateTime.MinValue),
                new Car("2222222", DateTime.MinValue),
                new MC("3333333", DateTime.MinValue),
                new Car("4444444", DateTime.MinValue),
            };

            //act
            int actual = api.Get().Count;

            //assert
            Assert.AreEqual(5,actual);
        }

        [TestMethod]
        public void GetByLicensplate()
        {
            //arrange
            api.Tickets = new List<Vehicle>()
            {
                new MC("0000000", DateTime.MinValue),
                new MC("1111111", DateTime.MinValue),
                new Car("2222222", DateTime.MinValue),
                new MC("3333333", DateTime.MinValue),
                new Car("4444444", DateTime.MinValue),
            };

            //act
            Vehicle actual = api.Get("3333333");

            //assert
            Assert.AreEqual(new MC("3333333", DateTime.MinValue), actual);
        }
    }
}
