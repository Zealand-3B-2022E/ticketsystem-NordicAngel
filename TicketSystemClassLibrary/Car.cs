namespace TicketSystemClassLibrary
{
    /// <summary>
    /// A record object of a car
    /// </summary>
    /// <param name="Licensplate">The cars licensplate</param>
    /// <param name="Date">When the car was registered</param>
    public record Car(string Licensplate, DateTime Date)
    {
        /// <summary>
        /// Returns the price of the car ticket
        /// </summary>
        public double Price() => 240;

        /// <summary>
        /// Returns what type of vehicle it is
        /// </summary>
        public string VehicleType() => "Car";
    }
}