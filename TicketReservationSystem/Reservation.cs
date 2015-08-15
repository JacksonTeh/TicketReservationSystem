using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketReservationSystem
{
    public class Reservation
    {
        protected Customer customer;
        protected TripInfo tripInfo;
        protected string seat;

        public Reservation() { }

        public Reservation(Customer customer, TripInfo tripInfo, string seat)
        {
            this.customer = customer;
            this.tripInfo = tripInfo;
            this.seat = seat;
        }

        public Customer getCustomer()
        { return customer; }

        public TripInfo getTripInfo()
        { return tripInfo; }

        public string getSeat()
        { return seat; }
    }
}
