using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCoverTest2
{
    public class Class1
    {
        public static string GetString(int index)
        {
            if (index == 0)
            {
                return "String1";
            }
            else
            {
                return "String2";
            }
        }
    }
}

