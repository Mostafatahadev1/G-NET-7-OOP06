using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_7_OOP06
{
    public class StandardTicket : Ticket
    {
        public Seat SeatNumber;

        public StandardTicket(string movie, Seat seat, decimal price)
            : base(movie, price)
        {
            SeatNumber = seat;
        }

        public override decimal CalculateFinalPrice()
        {
            return Price * 1.14m;
        }

        public override void Print()
        {
            Console.WriteLine(
            $"[Ticket #{TicketId}] {MovieName} | Standard | Seat: {SeatNumber} | Price: {Price} | Final: {CalculateFinalPrice():F2} | Booked: {(IsBooked ? "Yes" : "No")}");
        }
    }
}
