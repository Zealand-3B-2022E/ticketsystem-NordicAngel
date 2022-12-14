using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystemClassLibrary
{
    /// <summary>
    /// A record object of a motorcycle
    /// </summary>
    /// <param name="Licensplate">The motorcycle's licensplate</param>
    /// <param name="Date">When the ticket was bought</param>
    /// <param name="Brobizz">States weather the motorcycle used a brobizz</param>
    public record MC(string Licensplate, DateTime Date, bool Brobizz = false) : Vehicle(Licensplate, Date, Brobizz)
    {
        private const double _startPrice = 125;

        /// <summary>
        /// The ticket price of the motorcycle without discounts
        /// </summary>
        public override double StartPrice { get { return _startPrice; } }

        /// <summary>
        /// Returns the price of the MC ticket
        /// </summary>
        public override double Price() => Brobizz ? _startPrice * (1 - BrobizzDiscountPrecent) : _startPrice;

        /// <summary>
        /// Returns what type of vehicle it is
        /// </summary>
        public override string VehicleType() => "MC";
    }
}
