using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020820.interfaces
{
    interface IRentPayert : IArnonaPayer
    {
        // error
        //public IRentPayert()
        //{
        //
        //}
        // void PayArnona(); -- this i got from IArnonaPayer
        void PayRent(); // pay rent
        // error
        //static void Foo()
        //{

        //}
    }
}
