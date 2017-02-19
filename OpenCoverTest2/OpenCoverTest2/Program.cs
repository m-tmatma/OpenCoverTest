using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCoverTest2
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                try
                {
                    int index = Int32.Parse(args[0]);
                    Console.WriteLine(Class1.GetString(index));
                }
                catch (FormatException)
                {
                    Console.WriteLine("{0}: Bad Format", args[0]);
                }
                catch (OverflowException)
                {
                    Console.WriteLine("{0}: Overflow", args[0]);
                }
            }
        }
    }
}
