using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystemClassLibrary
{
    /// <summary>
    /// A record object of a vehicle
    /// </summary>
    /// <param name="Licensplate">The vehicle's licensplate</param>
    /// <param name="Date">When the vehicle was registered</param>
    public abstract record Vehicle(string Licensplate, DateTime Date)
    {
        /// <summary>
        /// Returns the price of the vehicle ticket
        /// </summary>
        public abstract double Price();

        /// <summary>
        /// Returns what type of vehicle it is
        /// </summary>
        public abstract string VehicleType();
    }
}
