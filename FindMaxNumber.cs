using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxNum
{
    public class FindMaxNumber
    {
        public int FindMaxInterger(int a, int b, int c)
        {
            if (a>b&& a>c)
            {
                return a;

            }
            else if (b>c && b>c)
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
