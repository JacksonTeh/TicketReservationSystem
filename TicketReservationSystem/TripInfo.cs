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
        protected string depart, arrive;
        protected double price;

        public TripInfo() { }

        public TripInfo(string code, string from, string to, string depart, string arrive, double price)
        {
            this.code = code;
            this.from = from;
            this.to = to;
            this.depart = depart;
            this.arrive = arrive;
            setPrice(price);
        }

        public string getCode()
        { return code; }

        public string getDepartFrom()
        { return from; }

        public string getDestination()
        { return to; }

        public string getDepart()
        { return depart; }

        public string getArrive()
        { return arrive; }

        public double getPrice()
        { return price; }

        public void setPrice(double price)
        { this.price = price; }
    }
}
