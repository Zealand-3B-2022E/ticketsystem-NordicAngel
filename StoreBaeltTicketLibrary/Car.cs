namespace StoreBaeltTicketLibrary
{
    /// <summary>
    /// A record object of a car
    /// </summary>
    /// <param name="Licensplate">The car's licensplate</param>
    /// <param name="Date">When the ticket was bought</param>
    /// <param name="Brobizz">States weather the car used a brobizz</param> 
    public record Car(string Licensplate, DateTime Date, bool Brobizz = false)
        : TicketSystemClassLibrary.Car(Licensplate, Date, Brobizz)
    {
        /// <summary>
        /// The ticket price of the car ticket
        /// </summary>
        public override double Price()
        {
            double price = StartPrice;
            const double weekendDiscount = 0.2;

            if (Date.DayOfWeek == DayOfWeek.Sunday || Date.DayOfWeek == DayOfWeek.Saturday)
                price *= 1 - weekendDiscount;

            if (Brobizz)
                price *= 1 - BrobizzDiscountPrecent;

            return price;
        }
    }
}