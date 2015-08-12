using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketReservationSystem
{
    class Customer
    {
        protected string loginID, password, name, customerType;
        protected int ic, contactNum;
        private static int customerCount = 0;

        public Customer() { }

        public Customer(string loginID, string password, string customerType,
                        string name, int ic, int contactNum)
        {
            setLogin(loginID, password);
            setCustomerInfo(customerType, name, ic, contactNum);
            /* Increment every time when this function is called */
            customerCount++;
        }

        public void setLogin(string loginID, string password)
        {
            this.loginID = loginID;
            this.password = password;
        }

        public void setCustomerInfo(string customerType, string name, int ic, int contactNum)
        {
            this.customerType = customerType;
            this.name = name;
            this.ic = ic;
            this.contactNum = contactNum;
        }
    }
}
