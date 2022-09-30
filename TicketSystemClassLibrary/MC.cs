using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystemClassLibrary
{
    /// <summary>
    /// A record object of a motor cycle
    /// </summary>
    /// <param name="Licensplate">The motor cycle's licensplate</param>
    /// <param name="Date">When the motor cycle was registered</param>
    public record MC(string Licensplate, DateTime Date)
    {
        /// <summary>
        /// Returns the price of the MC ticket
        /// </summary>
        public double Price() => 125;

        /// <summary>
        /// Returns what type of vehicle it is
        /// </summary>
        public string VehicleType() => "MC";
    }
}
