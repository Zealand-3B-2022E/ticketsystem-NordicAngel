namespace OresundbroenTicketLibrary
{
    /// <summary>
    /// A record object of a car
    /// </summary>
    /// <param name="Licensplate">The car's licensplate</param>
    /// <param name="Date">When the ticket was bought</param>
    /// <param name="Brobizz">States weather the car used a brobizz</param> 
    public record Car(string Licensplate, DateTime Date, bool Brobizz = false)
        : TicketSystemClassLibrary.Car(Licensplate,Date,Brobizz)
    {
        /// <summary>
        /// The ticket price of the car without discounts
        /// </summary>
        public override double StartPrice { get => 410 ; }
        private double _brobizzPrice = 161;

        /// <summary>
        /// The ticket price of the car ticket
        /// </summary>
        public override double Price() => Brobizz ? _brobizzPrice : StartPrice;
    }
}