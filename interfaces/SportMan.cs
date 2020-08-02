using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020820
{
    class SportMan : IRunner
    {
        private string _name;
        public string GetName()
        {
            return _name;
        }

        public SportMan(string name)
        {
            _name = name;
        }

        public void Run()
        {
            Console.WriteLine($"{_name} is running...");
        }


    }
}
