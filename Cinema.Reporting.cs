using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_7_OOP06
{
    public partial class Cinema
    {
        public void PrintAllTickets()
        {
            Console.WriteLine("\n--- All Tickets ---");

            foreach (var t in tickets)
            {
                if (t != null)
                {
                    t.Print();
                }
            }
        }
    }
}
