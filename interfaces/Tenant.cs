using _020820.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020820
{
    class Tenant : IRentPayert //, IArnonaPayer
    {
        public void PayArnona()
        {
            Console.WriteLine("Happy to pay arnona");
        }

        public void PayRent()
        {
            Console.WriteLine("Happy to pay rent...");
        }
    }
}
