﻿using System;
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
    public abstract record Vehicle(string Licensplate, DateTime Date)
    {
        internal string Licensplate { get; init; } = 
            Licensplate.Length > 7 ?
            throw new ArgumentOutOfRangeException("Licensplate's length exceded 7 charactars") :
            Licensplate;

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
