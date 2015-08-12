using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketReservationSystem
{
    class Reservation
    {
        protected Customer customer;
        protected string code, from, to, seat;
        protected DateTime depart, arrive;
        protected double price;

        public Reservation() { }

        public Reservation(Customer customer, string code, string from, string to, string seat,
                           DateTime depart, DateTime arrive, double price)
        {
            this.customer = customer;
            this.code = code;
            this.from = from;
            this.to = to;
            this.seat = seat;
            this.depart = depart;
            this.arrive = arrive;
            this.price = price;
        }

        public Customer getCustomer()
        { return customer; }

        public string getCode()
        { return code; }

        public string getDepartFrom()
        { return from; }

        public string getDestination()
        { return to; }

        public string getSeat()
        { return seat; }

        public DateTime getDepart()
        { return depart; }

        public DateTime getArrive()
        { return arrive; }

        public double getPrice()
        { return price; }
    }
}
