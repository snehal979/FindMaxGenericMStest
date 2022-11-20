using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxNum
{
    public class FindMaxNumber
    {
        public float FindMaxFloat(float a, float b, float c)
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
