using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_7_OOP06
{
    public class VIPTicket : Ticket
    {
        public bool LoungeAccess;
        public decimal ServiceFee;

        public VIPTicket(string movie, decimal price, bool lounge, decimal fee)
            : base(movie, price)
        {
            LoungeAccess = lounge;
            ServiceFee = fee;
        }

        public override decimal CalculateFinalPrice()
        {
            return (Price + ServiceFee) * 1.14m;
        }

        public override void Print()
        {
            Console.WriteLine(
            $"[Ticket #{TicketId}] {MovieName} | VIP | Lounge: {(LoungeAccess ? "Yes" : "No")} | Fee: {ServiceFee} | Price: {Price} | Final: {CalculateFinalPrice():F2} | Booked: {(IsBooked ? "Yes" : "No")}");
        }
    }
}
