using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace BankClassLibrary
{
    //[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
   // [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]

    public class Bank : IBank
    {
        //[ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]

        int counter = 0;

        public string Diposite()
        {
            return "Diposited at "+DateTime.Now.ToLongDateString();
        }

        public string Withdraw()
        {
            return "Withdrawn at " + DateTime.Now.ToLongDateString();
        }
        public string Increment()
        {
            return "Incremented at " + DateTime.Now.ToLongDateString()+" -- "+counter++;
        }
    }
}
