using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_7_OOP06
{
    public static class TicketExtensions
    {
        public static string GenerateReceipt(this Ticket t)
        {
            return
                        $@"========== RECEIPT ==========
                      Movie    : {t.MovieName}
                      Price    : {t.CalculateFinalPrice()}
                      Status   : {(t.IsBooked ? "Booked" : "Not Booked")}
                    =============================";
        }

        public static decimal TotalRevenue(this Ticket[] tickets)
        {
            decimal total = 0;

            foreach (var t in tickets)
            {
                if (t != null)
                    total += t.CalculateFinalPrice();
            }

            return total;
        }
    }
}
