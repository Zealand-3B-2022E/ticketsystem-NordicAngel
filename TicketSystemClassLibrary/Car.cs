namespace TicketSystemClassLibrary
{
    /// <summary>
    /// A record object of a car
    /// </summary>
    /// <param name="Licensplate">The car's licensplate</param>
    /// <param name="Date">When the ticket was bought</param>
    public record Car(string Licensplate, DateTime Date) : Vehicle(Licensplate, Date)
    {
        /// <summary>
        /// Returns the price of the car ticket
        /// </summary>
        public override double Price() => 240;

        /// <summary>
        /// Returns what type of vehicle it is
        /// </summary>
        public override string VehicleType() => "Car";
    }
}