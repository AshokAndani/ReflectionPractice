using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflections
{
    public class Custom
    {
        public void PrintHello(string a, string b)
        {
            Console.WriteLine("I got called [PrintHello]");
        }
        public string Name;
        public int FullName { get; set; }
        public Custom() { }
        public Custom(string name) { }

    }
    public class Ashok
    {
        public void sjdgbjhf(string a, string b)
        {
            Console.WriteLine("From Ashok");
        }
    }

}
