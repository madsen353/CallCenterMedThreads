using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenterWithThreads
{
    class ListOfCustomers
    {
        public ObservableCollection<Customer> CustomerList { get; set; }

        public ListOfCustomers()
        {
            CustomerList = new ObservableCollection<Customer>();

        }
    }
}
