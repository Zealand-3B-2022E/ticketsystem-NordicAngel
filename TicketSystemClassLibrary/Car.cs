namespace TicketSystemClassLibrary
{
    /// <summary>
    /// A record object of a car
    /// </summary>
    /// <param name="Licensplate">The car's licensplate</param>
    /// <param name="Date">When the ticket was bought</param>
    /// <param name="Brobizz">States weather the car used a brobizz</param>
    public record Car(string Licensplate, DateTime Date, bool Brobizz = false) : Vehicle(Licensplate, Date, Brobizz)
    {
        private const double _startPrice = 240;
        private const double _broBizzDiscount = 0.05;

        /// <summary>
        /// Returns the price of the car ticket
        /// </summary>
        public override double Price() => Brobizz ? _startPrice * (1 - _broBizzDiscount) : _startPrice;

        /// <summary>
        /// Returns what type of vehicle it is
        /// </summary>
        public override string VehicleType() => "Car";
    }
}