using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketReservationSystem
{
    public class TripInfo
    {
        protected string code, from, to;
        protected DateTime depart, arrive;
        protected double price;

        public TripInfo() { }

        public TripInfo(string code, string from, string to, DateTime depart, DateTime arrive, double price)
        {
            this.code = code;
            this.from = from;
            this.to = to;
            this.depart = depart;
            this.arrive = arrive;
            this.price = price;
        }

        public string getCode()
        { return code; }

        public string getDepartFrom()
        { return from; }

        public string getDestination()
        { return to; }

        public DateTime getDepart()
        { return depart; }

        public DateTime getArrive()
        { return arrive; }

        public double getPrice()
        { return price; }
    }
}
