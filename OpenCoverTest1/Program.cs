using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCoverTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test");

            foreach (var str in args)
            {
                Console.WriteLine(str);
            }
        }
    }
}
