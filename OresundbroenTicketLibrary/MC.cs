using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OresundbroenTicketLibrary
{
    /// <summary>
    /// A record object of a motorcycle
    /// </summary>
    /// <param name="Licensplate">The motorcycle's licensplate</param>
    /// <param name="Date">When the ticket was bought</param>
    /// <param name="Brobizz">States weather the motorcycle used a brobizz</param>
    public record MC(string Licensplate, DateTime Date, bool Brobizz = false) 
        : TicketSystemClassLibrary.MC(Licensplate,Date,Brobizz)
    {
        /// <summary>
        /// The ticket price of the MC
        /// </summary>
        public override double StartPrice { get => 210; }
        private double _brobizzPrice = 73;

        /// <summary>
        /// The ticket price of the MC ticket
        /// </summary>
        public override double Price() => Brobizz ? _brobizzPrice : StartPrice;
    }
}
