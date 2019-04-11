using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenterWithThreads
{
    public abstract class Customer
    {
        public IPriority Priority { get; set; }
        public string PhoneNumber { get; set; }

        public Customer(string inputPhone)
        {
            this.PhoneNumber = inputPhone;
        }
    }

    public class SilverCustomer : Customer
    {
        public SilverCustomer(string inputPhone) : base(inputPhone)
        {
            Priority = new Silver();
        }
    }

    public class GoldCustomer : Customer
    {

        public GoldCustomer(string inputPhone) : base(inputPhone)
        {
            Priority = new Gold();
        }
    }
}
