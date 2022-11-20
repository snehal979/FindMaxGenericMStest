using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxNum
{
    public class FindMaxNumber
    {
        public string FindMaxString(String a, String b, String c)
        {
            if (a.CompareTo(b)>0 && a.CompareTo(c)>0)
            {
                return a;

            }
            else if (b.CompareTo(c)>0 && b.CompareTo(c)>0)
            {
                return b;
            }
            else
            {
                return c;
            }

            
        }
    }
}
