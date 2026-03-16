using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_7_OOP06
{
    public abstract class Ticket
    {
        private static int counter = 0;

        public int TicketId { get; }

        public string MovieName { get; set; }

        protected decimal Price;

        protected bool isBooked = false;

        public bool IsBooked => isBooked;

        public Ticket(string movieName, decimal price)
        {
            counter++;
            TicketId = counter;
            MovieName = movieName;
            Price = price;
        }

        public void Book()
        {
            isBooked = true;
        }

        public void Cancel()
        {
            isBooked = false;
        }

        public abstract decimal CalculateFinalPrice();

        public virtual void Print()
        {
            Console.Write($"[Ticket #{TicketId}] {MovieName} | Price: {Price} | ");
        }
    }
}
