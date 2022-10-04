namespace StoreBaeltTicketLibrary
{
    public record Car(string Licensplate, DateTime Date, bool Brobizz = false)
        : TicketSystemClassLibrary.Car(Licensplate, Date, Brobizz)
    {
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