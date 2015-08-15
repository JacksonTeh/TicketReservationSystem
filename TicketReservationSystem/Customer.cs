using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketReservationSystem
{
    public class Customer
    {
        protected string loginID, password, name, customerType;
        protected string ic, contactNum;

        public Customer() { }

        public Customer(string loginID, string password, string customerType,
                        string name, string ic, string contactNum)
        {
            setLogin(loginID, password);
            setCustomerInfo(customerType, name, ic, contactNum);
        }

        public void setLogin(string loginID, string password)
        {
            this.loginID = loginID;
            this.password = password;
        }

        public void setCustomerInfo(string customerType, string name, string ic, string contactNum)
        {
            this.customerType = customerType;
            this.name = name;
            this.ic = ic;
            this.contactNum = contactNum;
        }

        public string getLoginID()
        { return this.loginID; }

        public string getPassword()
        { return this.password; }

        public string getCustomerName()
        { return this.name; }

        public string getIC()
        { return this.ic; }

        public string getContactNum()
        { return this.contactNum; }

        public string getCustomerType()
        { return this.customerType; }
    }
}
