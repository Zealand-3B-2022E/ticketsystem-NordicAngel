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
    /// <param name="Date">When the ticket was bought</param>
    /// <param name="Brobizz">States weather a vehicle used a brobizz</param>
    public abstract record Vehicle(string Licensplate, DateTime Date, bool Brobizz)
    {
        internal string Licensplate { get; init; } = 
            Licensplate.Length > 7 ?
            throw new ArgumentOutOfRangeException("Licensplate's length exceded 7 charactars") :
            Licensplate;

        /// <summary>
        /// The ticket price of a vehicle without discounts
        /// </summary>
        public abstract double StartPrice { get; }

        /// <summary>
        /// What the discount of using a brobizz is in percent
        /// </summary>
        public double BrobizzDiscountPrecent { get => 0.05; }

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
