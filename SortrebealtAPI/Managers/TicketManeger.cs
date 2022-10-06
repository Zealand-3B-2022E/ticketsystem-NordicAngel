using Microsoft.AspNetCore.Mvc;
using StoreBaeltTicketLibrary;
using TicketSystemClassLibrary;
using Car = StoreBaeltTicketLibrary.Car;

namespace SortrebealtAPI.Managers
{
    public static class TicketManeger
    {
        public static List<Vehicle> Tickets = new List<Vehicle>()
        {
            new MC("0000000", DateTime.MinValue),
            new MC("1111111", DateTime.MinValue),
            new Car("2222222", DateTime.MinValue),
            new MC("3333333", DateTime.MinValue),
            new Car("4444444", DateTime.MinValue),
        };

    public static Vehicle Create(Vehicle vehicle)
        {
            Tickets.Add(vehicle);
            return vehicle;
        }

        public static List<Vehicle> Get()
        {
            return Tickets.ToList();
        }

        public static Vehicle Get(string licensplate)
        {
            Vehicle ticket = Tickets.Find(v => v.Licensplate == licensplate);

            if (ticket == null)
                throw new KeyNotFoundException();

            return ticket;
        }
    }
}
